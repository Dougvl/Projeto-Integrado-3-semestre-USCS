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
    public partial class ConsultaProd : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public ConsultaProd()
        {
            InitializeComponent();
        }

        private void btnClickConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProd.Text != "" && txtNomeProd.Text == "")
                {
                    mDataSet = new DataSet();
                    mConn = new MySqlConnection(
                        "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    mAdapter = new MySqlDataAdapter($"SELECT * FROM produtos where codigoProduto = '{txtCodigoProd.Text}' order by nome_produto", mConn);

                    mAdapter.Fill(mDataSet, "produtos");
                    dataGridView1.DataSource = mDataSet;
                    dataGridView1.DataMember = "produtos";
                    mConn.Close();
                }

                if (txtNomeProd.Text != "" && txtCodigoProd.Text == "")
                {
                    mDataSet = new DataSet();
                    mConn = new MySqlConnection(
                        "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    mAdapter = new MySqlDataAdapter($"SELECT * FROM produtos where nome_produto ='{txtNomeProd.Text}' order by nome_produto", mConn);

                    mAdapter.Fill(mDataSet, "cliente");
                    dataGridView1.DataSource = mDataSet;
                    dataGridView1.DataMember = "cliente";
                    mConn.Close();
                }

                if (txtNomeProd.Text == "" && txtCodigoProd.Text == "")
                {
                    mDataSet = new DataSet();
                    mConn = new MySqlConnection(
                        "Persist Security Info=False; server=localhost;database=primatas_systems;uid=root");
                    mConn.Open();

                    mAdapter = new MySqlDataAdapter("SELECT * FROM produtos order by nome_produto", mConn);

                    mAdapter.Fill(mDataSet, "produtos");
                    dataGridView1.DataSource = mDataSet;
                    dataGridView1.DataMember = "produtos";
                    mConn.Close();
                }

                txtCodigoProd.Clear();
                txtNomeProd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
