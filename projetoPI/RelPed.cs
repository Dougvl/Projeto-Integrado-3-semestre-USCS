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
    public partial class RelPed : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public RelPed()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPed_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodCli.Text != "" && txtNumPed.Text == "")
                {
                    dataGridView1.Rows.Clear();
                    mConn = new MySqlConnection(
                  "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    string consultaSql =
                        String.Format($"select * from pedido where id_cliente = '{txtCodCli.Text}' order by idVenda", mConn);
                    MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1].ToString(), DateTime.Now.ToString(), reader[3].ToString(), reader[4].ToString());

                    }
                    mConn.Close();
                }

                if (txtNumPed.Text != "" && txtCodCli.Text == "")
                {
                    dataGridView1.Rows.Clear();
                    mConn = new MySqlConnection(
                  "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    string consultaSql =
                        String.Format($"select * from pedido where idVenda = '{txtNumPed.Text}' order by idVenda", mConn);
                    MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1].ToString(), DateTime.Now.ToString(), reader[3].ToString(), reader[4].ToString());

                    }
                    mConn.Close();
                }

                if (txtNumPed.Text == "" && txtCodCli.Text == "")
                {
                    dataGridView1.Rows.Clear();
                    mConn = new MySqlConnection(
                   "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    string consultaSql =
                        String.Format($"select * from pedido order by idVenda", mConn);
                    MySqlCommand command = new MySqlCommand(consultaSql, mConn);
                    command.CommandType = CommandType.Text;

                    MySqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1].ToString(), DateTime.Now.ToString(), reader[3].ToString(), reader[4].ToString());

                    }
                    mConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
