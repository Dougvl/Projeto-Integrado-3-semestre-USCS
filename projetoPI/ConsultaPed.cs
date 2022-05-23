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
    public partial class ConsultaPed : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        private List<Pedido> listPedido = new List<Pedido>();
        double precoTotal;
        string teste1;
        public ConsultaPed()
        {
            InitializeComponent();
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.Rows.Clear();
                mConn = new MySqlConnection(
                   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format($"select pedidoxproduto.*, produtos.nome_produto from pedidoxproduto inner join produtos on pedidoxproduto.codigoProduto = produtos.codigoProduto where pedidoxproduto.idVenda = ?", mConn);
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.Clear();
                command.Parameters.Add("@pedidoxproduto", MySqlDbType.Int32).Value = txtNumPed.Text;
                MySqlDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    double preco = double.Parse(reader[3].ToString()) * double.Parse(reader[2].ToString());
                    precoTotal += preco;
                    dataGridView1.Rows.Add(dataGridView1.RowCount, reader[1].ToString(), reader[4].ToString(), reader[2].ToString(), reader[3].ToString(), preco.ToString());
                    txtTotalPed.Text = precoTotal.ToString();
                }
                mConn.Close();

                mConn = new MySqlConnection(
                   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql1 =
                    String.Format($"select id_cliente from pedido where idVenda =?", mConn);
                MySqlCommand command1 = new MySqlCommand(consultaSql1, mConn);
                command1.Parameters.Clear();
                command1.Parameters.Add("@cliente", MySqlDbType.Int32).Value = txtNumPed.Text;

                command1.CommandType = CommandType.Text;

                MySqlDataReader reader1;
                reader1 = command1.ExecuteReader();
                reader1.Read();

                txtCodCli.Text = reader1.GetString(0);
                mConn.Close();

                mConn = new MySqlConnection(
                   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql2 =
                    String.Format($"select nome, cpf, logradouro from cliente where id_cliente =?", mConn);
                MySqlCommand command2 = new MySqlCommand(consultaSql2, mConn);
                command2.Parameters.Clear();
                command2.Parameters.Add("@cliente", MySqlDbType.Int32).Value = txtCodCli.Text;


                command2.CommandType = CommandType.Text;

                MySqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                reader2.Read();

                txtNomeCli.Text = reader2.GetString(0);
                txtCpfCli.Text = reader2.GetString(1);
                txtLogradoudoCli.Text = reader2.GetString(2);
                mConn.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Preencha o codigo do pedido");
            }

            //mConn = new MySqlConnection(
            //   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
            //mConn.Open();

            //string consultaSql3 =
            //    String.Format($"select nome_produto from produtos where codigoProduto =?", mConn);
            //MySqlCommand command3 = new MySqlCommand(consultaSql3, mConn);
            //command3.Parameters.Clear();
            //command3.Parameters.Add("@produto", MySqlDbType.VarChar).Value = teste1;


            //command3.CommandType = CommandType.Text;

            //MySqlDataReader reader3;
            //reader3 = command3.ExecuteReader();
            //reader3.Read();

            //txtNomeCli.Text = reader3.GetString(0);
            //txtCpfCli.Text = reader3.GetString(1);
            //txtLogradoudoCli.Text = reader3.GetString(2);
            //mConn.Close();


            //txtTeste.Text = dataGridView1.RowCount.ToString();
        }
    }
}
