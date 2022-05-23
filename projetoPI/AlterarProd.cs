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
    public partial class AlterarProd : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public AlterarProd()
        {
            InitializeComponent();
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnBuscarCli.Text != "")
                {
                    mConn = new MySqlConnection(
                   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    string consultaSql =
                        String.Format($"select nome_produto, preco from produtos where codigoProduto =?", mConn);
                    MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                    command.Parameters.Clear();
                    command.Parameters.Add("@produtos", MySqlDbType.VarChar).Value = txtCodProd.Text;


                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    reader.Read();

                    txtNomeProd.Text = reader.GetString(0);
                    txtValorProd.Text = reader.GetString(1);



                    //command.ExecuteNonQuery();


                    mConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira codigo do produto");
            }
            
        }

        private void btnAltProd_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produtos = new Produtos();

                produtos.CodProduto = txtCodProd.Text;
                produtos.ValorProduto = double.Parse(txtValorProd.Text);
                produtos.NomeProduto = txtNomeProd.Text;

                mConn = new MySqlConnection(
                    "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format($"update produtos set nome_produto = \"{produtos.NomeProduto}\" , preco = \"{produtos.ValorProduto}\" where codigoProduto = ? ");
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.Clear();
                command.Parameters.Add("@produtos", MySqlDbType.Int32).Value = txtCodProd.Text;
                command.ExecuteNonQuery();
                mConn.Close();

                txtCodProd.Clear();
                txtNomeProd.Clear();
                txtValorProd.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Produto Alterado com sucesso");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                mConn = new MySqlConnection(
                "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format($"delete from produtos where codigoProduto = ? ");
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.Clear();
                command.Parameters.Add("@produtos", MySqlDbType.VarChar).Value = txtCodProd.Text;
                command.ExecuteNonQuery();
                mConn.Close();

                txtCodProd.Clear();
                txtNomeProd.Clear();
                txtValorProd.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Cliente deletado com sucesso");
            }
        }
    }
}
