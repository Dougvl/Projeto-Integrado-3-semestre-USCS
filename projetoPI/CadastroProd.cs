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
    public partial class CadastroProd : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public CadastroProd()
        {
            InitializeComponent();
        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produto = new Produtos();
                produto.CodProduto = txtCodProd.Text;
                produto.NomeProduto = txtNomeProd.Text;
                produto.ValorProduto = double.Parse(txtValorProd.Text);
                mConn = new MySqlConnection(
                   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format("INSERT INTO produtos (codigoProduto, nome_produto, preco) values ('{0}','{1}','{2}')",
                    produto.CodProduto, produto.NomeProduto, produto.ValorProduto);
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
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
                MessageBox.Show("Produto Cadastrado com sucesso");
            }



        }

    }
}
