namespace projetoPI
{
    partial class RelPed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumPed = new System.Windows.Forms.TextBox();
            this.btnBuscarPed = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(108, 24);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(118, 23);
            this.txtCodCli.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Codigo Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Pedido N";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtNumPed
            // 
            this.txtNumPed.Location = new System.Drawing.Point(331, 24);
            this.txtNumPed.Name = "txtNumPed";
            this.txtNumPed.Size = new System.Drawing.Size(168, 23);
            this.txtNumPed.TabIndex = 28;
            // 
            // btnBuscarPed
            // 
            this.btnBuscarPed.Location = new System.Drawing.Point(525, 23);
            this.btnBuscarPed.Name = "btnBuscarPed";
            this.btnBuscarPed.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPed.TabIndex = 29;
            this.btnBuscarPed.Text = "Buscar";
            this.btnBuscarPed.UseVisualStyleBackColor = true;
            this.btnBuscarPed.Click += new System.EventHandler(this.btnBuscarPed_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 322);
            this.dataGridView1.TabIndex = 30;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(projetoPI.Pedido);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(projetoPI.Produtos);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Venda";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Data Pedido";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor do Pedido";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantidade de Produtos";
            this.Column5.Name = "Column5";
            // 
            // ConsultaPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarPed);
            this.Controls.Add(this.txtNumPed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaPed";
            this.Text = "ConsultaPed";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCodCli;
        private Label label1;
        private Label label11;
        private TextBox txtNumPed;
        private Button btnBuscarPed;
        private DataGridView dataGridView1;
        private BindingSource pedidoBindingSource;
        private BindingSource produtosBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}