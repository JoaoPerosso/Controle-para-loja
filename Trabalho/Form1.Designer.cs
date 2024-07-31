namespace Trabalho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirExcluirAlterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirExcluirAlterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirExcluirAlterarToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // inserirExcluirAlterarToolStripMenuItem
            // 
            this.inserirExcluirAlterarToolStripMenuItem.Name = "inserirExcluirAlterarToolStripMenuItem";
            this.inserirExcluirAlterarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.inserirExcluirAlterarToolStripMenuItem.Text = "Inserir/Excluir/Alterar";
            this.inserirExcluirAlterarToolStripMenuItem.Click += new System.EventHandler(this.inserirExcluirAlterarToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirExcluirAlterarToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // inserirExcluirAlterarToolStripMenuItem1
            // 
            this.inserirExcluirAlterarToolStripMenuItem1.Name = "inserirExcluirAlterarToolStripMenuItem1";
            this.inserirExcluirAlterarToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.inserirExcluirAlterarToolStripMenuItem1.Text = "Inserir/Excluir/Alterar";
            this.inserirExcluirAlterarToolStripMenuItem1.Click += new System.EventHandler(this.inserirExcluirAlterarToolStripMenuItem1_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // gráficoToolStripMenuItem
            // 
            this.gráficoToolStripMenuItem.Name = "gráficoToolStripMenuItem";
            this.gráficoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gráficoToolStripMenuItem.Text = "Gráfico";
            this.gráficoToolStripMenuItem.Click += new System.EventHandler(this.gráficoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "Venda:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(215, 121);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 1;
            this.txtCodCli.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodCli_KeyUp);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(792, 199);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(605, 199);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 5;
            this.txtQtde.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtde_KeyUp);
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(231, 199);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.ReadOnly = true;
            this.txtDescr.Size = new System.Drawing.Size(196, 20);
            this.txtDescr.TabIndex = 8;
            this.txtDescr.TabStop = false;
            // 
            // txtCodPro
            // 
            this.txtCodPro.Location = new System.Drawing.Point(39, 199);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(114, 20);
            this.txtCodPro.TabIndex = 3;
            this.txtCodPro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodPro_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código do Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Código do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(808, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome do Cliente:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionar.Location = new System.Drawing.Point(783, 234);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(134, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(459, 199);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(565, 120);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 19);
            this.lblNome.TabIndex = 21;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Crimson;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(18, 234);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(134, 23);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.TabStop = false;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(20, 273);
            this.dgvVenda.MultiSelect = false;
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.RowHeadersVisible = false;
            this.dgvVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(897, 292);
            this.dgvVenda.TabIndex = 23;
            this.dgvVenda.TabStop = false;
            this.dgvVenda.DoubleClick += new System.EventHandler(this.dgvVenda_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(788, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total Compra:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTotalCompra.Location = new System.Drawing.Point(798, 63);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCompra.TabIndex = 24;
            this.txtTotalCompra.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 577);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodPro);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "\\";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirExcluirAlterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirExcluirAlterarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalCompra;
    }
}

