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
    public partial class AlterarCli : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public AlterarCli()
        {
            InitializeComponent();
        }

        private void AlterarCli_Load(object sender, EventArgs e)
        {

        }

        private void btnAltCadastro_Click(object sender, EventArgs e)
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
                cliente01.Cidade = txtCidadeCli.Text;
                cliente01.Estado = comboBoxEstado.Text;
                cliente01.Cep = txtCepCli.Text;
                cliente01.Complemento = txtComplementoCli.Text;

                mConn = new MySqlConnection(
                    "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                string consultaSql =
                    String.Format($"update cliente set nome = \"{cliente01.Nome}\" , cpf = \"{cliente01.Cpf}\", telefone = \"{cliente01.Telefone}\", email = \"{cliente01.Email}\", logradouro= \"{cliente01.Logradouro}\", numero =\"{cliente01.Numero}\", cidade = \"{cliente01.Cidade}\", estado = \"{cliente01.Estado}\", cep=\"{cliente01.Cep}\", complemento=\"{cliente01.Complemento}\" where id_cliente = ? ");
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.Clear();
                command.Parameters.Add("@cliente", MySqlDbType.Int32).Value = txtCodigoCli.Text;
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
                MessageBox.Show("Cliente alterado com sucesso");
            }
            
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
                        String.Format($"select nome, cpf, telefone, email, logradouro, numero, complemento, cidade, estado, cep from cliente where id_cliente =?", mConn);
                    MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                    command.Parameters.Clear();
                    command.Parameters.Add("@cliente", MySqlDbType.Int32).Value = txtCodigoCli.Text;


                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    reader.Read();

                    txtNomeCli.Text = reader.GetString(0);
                    txtCpfCli.Text = reader.GetString(1);
                    txtTelefoneCli.Text = reader.GetString(2);
                    txtEmailCli.Text = reader.GetString(3);
                    txtLogradouro.Text = reader.GetString(4);
                    txtNumeroCli.Text = reader.GetString(5);
                    txtComplementoCli.Text= reader.GetString(6);
                    txtCidadeCli.Text = reader.GetString(7);
                    comboBoxEstado.Text = reader.GetString(8);
                    txtCepCli.Text = reader.GetString(9);


                    //command.ExecuteNonQuery();


                    mConn.Close();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campo Codigo do Cliente deve ser preenchido");
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
                    String.Format($"delete from cliente where id_cliente = ? ");
                MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                command.Parameters.Clear();
                command.Parameters.Add("@cliente", MySqlDbType.Int32).Value = txtCodigoCli.Text;
                command.ExecuteNonQuery();
                mConn.Close();
                txtCodigoCli.Clear();
                txtCidadeCli.Clear();
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
                MessageBox.Show("Campo Codigo do Cliente deve ser preenchido");
            }
            finally
            {
                MessageBox.Show("Cliente deletado com sucesso");
            }
        }
    }
}
