namespace teste
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
            this.components = new System.ComponentModel.Container();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLucroBruto = new System.Windows.Forms.TextBox();
            this.lblMargemLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFaturamento = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(226, 26);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(189, 20);
            this.txtCusto.TabIndex = 0;
            this.txtCusto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(226, 61);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(189, 20);
            this.txtPrecoVenda.TabIndex = 1;
            this.txtPrecoVenda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lucro Bruto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Margem de lucro";
            this.label2.Click += new System.EventHandler(this.lblMargemLucro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLucroBruto
            // 
            this.lblLucroBruto.BackColor = System.Drawing.SystemColors.Window;
            this.lblLucroBruto.Enabled = false;
            this.lblLucroBruto.Location = new System.Drawing.Point(226, 176);
            this.lblLucroBruto.Name = "lblLucroBruto";
            this.lblLucroBruto.Size = new System.Drawing.Size(189, 20);
            this.lblLucroBruto.TabIndex = 5;
            // 
            // lblMargemLucro
            // 
            this.lblMargemLucro.BackColor = System.Drawing.SystemColors.Window;
            this.lblMargemLucro.Enabled = false;
            this.lblMargemLucro.Location = new System.Drawing.Point(226, 213);
            this.lblMargemLucro.Name = "lblMargemLucro";
            this.lblMargemLucro.Size = new System.Drawing.Size(189, 20);
            this.lblMargemLucro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Custo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço da venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade de produtos";
            // 
            // txtQtdProduto
            // 
            this.txtQtdProduto.AccessibleName = "";
            this.txtQtdProduto.Location = new System.Drawing.Point(226, 98);
            this.txtQtdProduto.Name = "txtQtdProduto";
            this.txtQtdProduto.Size = new System.Drawing.Size(189, 20);
            this.txtQtdProduto.TabIndex = 11;
            this.txtQtdProduto.TextChanged += new System.EventHandler(this.txtQtdProduto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Custo total";
            // 
            // lblCustoTotal
            // 
            this.lblCustoTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblCustoTotal.Enabled = false;
            this.lblCustoTotal.Location = new System.Drawing.Point(226, 250);
            this.lblCustoTotal.Name = "lblCustoTotal";
            this.lblCustoTotal.Size = new System.Drawing.Size(189, 20);
            this.lblCustoTotal.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Faturamento";
            // 
            // lblFaturamento
            // 
            this.lblFaturamento.BackColor = System.Drawing.SystemColors.Window;
            this.lblFaturamento.Enabled = false;
            this.lblFaturamento.Location = new System.Drawing.Point(226, 284);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(189, 20);
            this.lblFaturamento.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 369);
            this.Controls.Add(this.lblFaturamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCustoTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQtdProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMargemLucro);
            this.Controls.Add(this.lblLucroBruto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtCusto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblLucroBruto;
        private System.Windows.Forms.TextBox lblMargemLucro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtdProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblCustoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblFaturamento;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

