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
    public partial class ConsultaCli : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public ConsultaCli()
        {
            InitializeComponent();
           
        }

        private void btnClickConsulta_Click_1(object sender, EventArgs e)
        {

            if (txtCodigoCli.Text != "" && txtNomeCli.Text == "")
            {
                mDataSet = new DataSet();
            mConn = new MySqlConnection(
                "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
            mConn.Open();

            mAdapter = new MySqlDataAdapter($"SELECT * FROM cliente where id_cliente = '{txtCodigoCli.Text}' order by id_cliente", mConn);

            mAdapter.Fill(mDataSet, "cliente");
            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "cliente";
            mConn.Close();
            }

            if (txtNomeCli.Text != "" && txtCodigoCli.Text == "")
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection(
                    "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                mAdapter = new MySqlDataAdapter($"SELECT * FROM cliente where nome ='{txtNomeCli.Text}' order by id_cliente", mConn);

                mAdapter.Fill(mDataSet, "cliente");
                dataGridView1.DataSource = mDataSet;
                dataGridView1.DataMember = "cliente";
                mConn.Close();
            }

            if (txtNomeCli.Text == "" && txtCodigoCli.Text == "")
            {
                mDataSet = new DataSet();
                mConn = new MySqlConnection(
                    "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                mConn.Open();

                mAdapter = new MySqlDataAdapter("SELECT * FROM cliente order by id_cliente", mConn);

                mAdapter.Fill(mDataSet, "cliente");
                dataGridView1.DataSource = mDataSet;
                dataGridView1.DataMember = "cliente";
                mConn.Close();
            }

            txtCodigoCli.Clear();
            txtNomeCli.Clear();
        }

       
    }
}
