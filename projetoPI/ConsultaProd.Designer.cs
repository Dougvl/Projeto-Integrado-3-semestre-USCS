namespace projetoPI
{
    partial class ConsultaProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClickConsulta = new System.Windows.Forms.Button();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lbNomeCli = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.lbCodigoCli = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClickConsulta
            // 
            this.btnClickConsulta.Location = new System.Drawing.Point(377, 17);
            this.btnClickConsulta.Name = "btnClickConsulta";
            this.btnClickConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnClickConsulta.TabIndex = 10;
            this.btnClickConsulta.Text = "Buscar";
            this.btnClickConsulta.UseVisualStyleBackColor = true;
            this.btnClickConsulta.Click += new System.EventHandler(this.btnClickConsulta_Click);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(242, 17);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(100, 23);
            this.txtNomeProd.TabIndex = 9;
            // 
            // lbNomeCli
            // 
            this.lbNomeCli.AutoSize = true;
            this.lbNomeCli.Location = new System.Drawing.Point(190, 20);
            this.lbNomeCli.Name = "lbNomeCli";
            this.lbNomeCli.Size = new System.Drawing.Size(40, 15);
            this.lbNomeCli.TabIndex = 8;
            this.lbNomeCli.Text = "Nome";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(64, 17);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoProd.TabIndex = 7;
            // 
            // lbCodigoCli
            // 
            this.lbCodigoCli.AutoSize = true;
            this.lbCodigoCli.Location = new System.Drawing.Point(12, 20);
            this.lbCodigoCli.Name = "lbCodigoCli";
            this.lbCodigoCli.Size = new System.Drawing.Size(46, 15);
            this.lbCodigoCli.TabIndex = 6;
            this.lbCodigoCli.Text = "Codigo";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(projetoPI.Cliente);
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataSource = typeof(projetoPI.Endereco);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(projetoPI.Produtos);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.NomeProduto,
            this.preco,
            this.qntEstoque});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(798, 392);
            this.dataGridView1.TabIndex = 11;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "codigoProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "nome_produto";
            this.NomeProduto.HeaderText = "Nome";
            this.NomeProduto.Name = "NomeProduto";
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "ValorProduto";
            this.preco.Name = "preco";
            // 
            // qntEstoque
            // 
            this.qntEstoque.DataPropertyName = "qntEstoque";
            this.qntEstoque.HeaderText = "Quantidade";
            this.qntEstoque.Name = "qntEstoque";
            // 
            // ConsultaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClickConsulta);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.lbNomeCli);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.lbCodigoCli);
            this.Name = "ConsultaProd";
            this.Text = "ConsultaProd";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClickConsulta;
        private TextBox txtNomeProd;
        private Label lbNomeCli;
        private TextBox txtCodigoProd;
        private Label lbCodigoCli;
        private BindingSource clienteBindingSource;
        private BindingSource enderecoBindingSource;
        private BindingSource produtosBindingSource;
        private DataGridViewTextBoxColumn Nome;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn qntEstoque;
    }
}