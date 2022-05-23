namespace projetoPI
{
    partial class NovoPed
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQntProd = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpfCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogradoudoCli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalPed = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDataPed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumPed = new System.Windows.Forms.TextBox();
            this.txtTeste = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(113, 16);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(168, 23);
            this.txtCodCli.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adicionar Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo Produto";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(132, 122);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(100, 23);
            this.txtCodProd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // txtQntProd
            // 
            this.txtQntProd.Location = new System.Drawing.Point(329, 122);
            this.txtQntProd.Name = "txtQntProd";
            this.txtQntProd.Size = new System.Drawing.Size(100, 23);
            this.txtQntProd.TabIndex = 7;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(453, 121);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 23);
            this.btnAddProd.TabIndex = 8;
            this.btnAddProd.Text = "Adicionar";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Codigo,
            this.Column1,
            this.Quantidade,
            this.Preco,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 240);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preco Unitario";
            this.Preco.Name = "Preco";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(302, 16);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCli.TabIndex = 10;
            this.btnBuscarCli.Text = "Adicionar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(113, 52);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.ReadOnly = true;
            this.txtNomeCli.Size = new System.Drawing.Size(168, 23);
            this.txtNomeCli.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome";
            // 
            // txtCpfCli
            // 
            this.txtCpfCli.Location = new System.Drawing.Point(346, 52);
            this.txtCpfCli.Name = "txtCpfCli";
            this.txtCpfCli.ReadOnly = true;
            this.txtCpfCli.Size = new System.Drawing.Size(168, 23);
            this.txtCpfCli.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "CPF";
            // 
            // txtLogradoudoCli
            // 
            this.txtLogradoudoCli.Location = new System.Drawing.Point(606, 52);
            this.txtLogradoudoCli.Name = "txtLogradoudoCli";
            this.txtLogradoudoCli.ReadOnly = true;
            this.txtLogradoudoCli.Size = new System.Drawing.Size(168, 23);
            this.txtLogradoudoCli.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Logradouro";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(projetoPI.Produtos);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total";
            // 
            // txtTotalPed
            // 
            this.txtTotalPed.Location = new System.Drawing.Point(564, 413);
            this.txtTotalPed.Name = "txtTotalPed";
            this.txtTotalPed.ReadOnly = true;
            this.txtTotalPed.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPed.TabIndex = 18;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(699, 413);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDataPed
            // 
            this.txtDataPed.Location = new System.Drawing.Point(606, 16);
            this.txtDataPed.Name = "txtDataPed";
            this.txtDataPed.ReadOnly = true;
            this.txtDataPed.Size = new System.Drawing.Size(168, 23);
            this.txtDataPed.TabIndex = 20;
            this.txtDataPed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(564, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Data";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Pedido N";
            // 
            // txtNumPed
            // 
            this.txtNumPed.Location = new System.Drawing.Point(454, 14);
            this.txtNumPed.Name = "txtNumPed";
            this.txtNumPed.ReadOnly = true;
            this.txtNumPed.Size = new System.Drawing.Size(100, 23);
            this.txtNumPed.TabIndex = 23;
            // 
            // txtTeste
            // 
            this.txtTeste.Location = new System.Drawing.Point(635, 84);
            this.txtTeste.Name = "txtTeste";
            this.txtTeste.Size = new System.Drawing.Size(100, 23);
            this.txtTeste.TabIndex = 24;
            // 
            // NovoPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTeste);
            this.Controls.Add(this.txtNumPed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataPed);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTotalPed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLogradoudoCli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCpfCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.btnBuscarCli);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.txtQntProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label1);
            this.Name = "NovoPed";
            this.Text = "NovoPed";
            this.Load += new System.EventHandler(this.NovoPed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCodCli;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodProd;
        private Label label5;
        private TextBox txtQntProd;
        private Button btnAddProd;
        private DataGridView dataGridView1;
        private Button btnBuscarCli;
        private TextBox txtNomeCli;
        private Label label6;
        private TextBox txtCpfCli;
        private Label label7;
        private TextBox txtLogradoudoCli;
        private Label label8;
        private BindingSource produtosBindingSource;
        private Label label9;
        private TextBox txtTotalPed;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Total;
        private Button btnSalvar;
        private TextBox txtDataPed;
        private Label label10;
        private Label label11;
        private TextBox txtNumPed;
        private TextBox txtTeste;
    }
}