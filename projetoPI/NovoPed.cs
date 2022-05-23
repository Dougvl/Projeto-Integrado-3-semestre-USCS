using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPI
{
    public partial class NovoPed : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        private List<Pedido> listPedido = new List<Pedido>();
        double precoTotal;
        DateTime data = DateTime.UtcNow;
        


        public NovoPed()
        {
            InitializeComponent();
        }

        private void NovoPed_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mConn = new MySqlConnection(
               "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format($"select codigoProduto, nome_produto, preco, qntEstoque from produtos where codigoProduto =?", mConn);
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.Clear();
                command.Parameters.Add("@produtos", MySqlDbType.VarChar).Value = txtCodProd.Text;
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    double preco = double.Parse(txtQntProd.Text.ToString()) * double.Parse(reader[2].ToString());
                    precoTotal += preco;
                    dataGridView1.Rows.Add(dataGridView1.RowCount, reader[0], reader[1].ToString(), txtQntProd.Text.Trim(), reader[2], preco.ToString());
                    txtTotalPed.Text = precoTotal.ToString();
                }
                txtDataPed.Text = data.ToString();
                mConn.Close();
                txtTeste.Text = dataGridView1.RowCount.ToString();
            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message);
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            try
            {
                mConn = new MySqlConnection(
                 "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format($"select nome, cpf, logradouro from cliente where id_cliente =?", mConn);
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.Clear();
                command.Parameters.Add("@cliente", MySqlDbType.Int32).Value = txtCodCli.Text;


                command.CommandType = CommandType.Text;

                MySqlDataReader reader;
                reader = command.ExecuteReader();
                reader.Read();

                txtNomeCli.Text = reader.GetString(0);
                txtCpfCli.Text = reader.GetString(1);
                txtLogradoudoCli.Text = reader.GetString(2);
                mConn.Close();

                txtDataPed.Text = data.ToString();
                mConn = new MySqlConnection(
                   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql1 =
                    String.Format($"SELECT MAX(idVenda) as maxId FROM pedido", mConn);
                MySqlCommand command1 = new MySqlCommand(consultaSql1, mConn);
                command1.Parameters.Clear();



                command1.CommandType = CommandType.Text;

                MySqlDataReader reader1;
                reader1 = command1.ExecuteReader();
                reader1.Read();
                string pedidoatual = reader1.GetString(0);
                int proximoPed = Convert.ToInt32(pedidoatual) + 1;
                txtNumPed.Text = proximoPed.ToString();
                mConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                mConn = new MySqlConnection(
                    "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format("INSERT INTO pedido (id_cliente, dataPedido , totalPedido) values (@id_cliente, @dataPedido, @totalPedido)");
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.AddWithValue("@id_cliente", txtCodCli.Text);
                command.Parameters.AddWithValue("@dataPedido", data);
                command.Parameters.AddWithValue("@totalPedido", precoTotal);

                command.ExecuteNonQuery();
                mConn.Close();



                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    mConn = new MySqlConnection(
                      "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    string consultaSql1 =
                        String.Format("INSERT INTO pedidoxproduto (idVenda, codigoProduto, qntItem , precoProd) values (@idVenda, @codigoProduto, @qntItem, @precoProd)");
                    MySqlCommand command1 = new MySqlCommand(consultaSql1, mConn);
                    command1.Parameters.AddWithValue("@idVenda", txtNumPed.Text);
                    command1.Parameters.AddWithValue("@codigoProduto", dataGridView1.Rows[i].Cells[1].Value);
                    command1.Parameters.AddWithValue("@qntItem", dataGridView1.RowCount - 1);
                    command1.Parameters.AddWithValue("@precoProd", dataGridView1.Rows[i].Cells[5].Value);
                    //command.Parameters.AddWithValue("@qntProdutos", dataGridView1.Rows.Cells[2].Value);
                    command1.ExecuteNonQuery();
                    mConn.Close();
                }
                txtQntProd.Clear();
                txtCodProd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtDataPed.Text = data.ToString();
        }

        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
