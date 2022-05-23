namespace projetoPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCli consultaCli = new ConsultaCli();
            consultaCli.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

  
        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCli cliente = new CadastroCli();
            cliente.Show();
        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarCli alterarCli = new AlterarCli();
            alterarCli.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProd consultaProd = new ConsultaProd();
            consultaProd.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProd clienteProd = new CadastroProd();
            clienteProd.Show();
        }

        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarProd alterarProd = new AlterarProd();
            alterarProd.Show();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoPed novoPed = new NovoPed();
            novoPed.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelPed consultaPed = new RelPed();
            consultaPed.Show();
        }

        private void consultaPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPed consultaPed = new ConsultaPed();
            consultaPed.Show();
        }
    }
}