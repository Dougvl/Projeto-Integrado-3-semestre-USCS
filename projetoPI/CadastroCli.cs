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
    public partial class CadastroCli : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public CadastroCli()
        {
            InitializeComponent();

        }
                       

        private void CadastroCli_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente01 = new Cliente();
                cliente01.Nome = txtNomeCli.Text;
                cliente01.Email = txtEmailCli.Text;
                cliente01.Cpf = txtCpfCli.Text;
                cliente01.Telefone = txtTelefoneCli.Text;
                cliente01.Logradouro = txtLogradouro.Text;
                cliente01.Numero = txtNumeroCli.Text;
                cliente01.Estado = comboBoxEstado.Text;
                cliente01.Cep = txtCepCli.Text;
                cliente01.Complemento = txtComplementoCli.Text;

                mConn = new MySqlConnection(
                    "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format("INSERT INTO cliente (nome, cpf, telefone, email, logradouro, numero, cidade, cep) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    cliente01.Nome, cliente01.Email, cliente01.Cpf, cliente01.Telefone, cliente01.Logradouro, cliente01.Numero, cliente01.Cep, cliente01.Complemento);
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.ExecuteNonQuery();
                mConn.Close();

                txtNomeCli.Clear();
                txtEmailCli.Clear();
                txtCpfCli.Clear();
                txtTelefoneCli.Clear();
                txtLogradouro.Clear();
                txtNumeroCli.Clear();
                txtCepCli.Clear();
                txtComplementoCli.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Cliente cadastrado com sucesso");
            }





            //cliente01.Endereco.Logradouro = txtLogradouro.Text;
            //cliente01.Endereco.Numero = txtNumeroCli.Text;
            //cliente01.Endereco.Cep = txtCepCli.Text;

        }
    }
}
