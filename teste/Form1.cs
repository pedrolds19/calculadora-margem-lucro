using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora de margem de lucro";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCusto.Text))
            {
                MessageBox.Show("O campo 'Custo' é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCusto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrecoVenda.Text))
            {
                MessageBox.Show("O campo 'Preço de Venda' é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoVenda.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQtdProduto.Text))
            {
                MessageBox.Show("O campo 'Quantidade de produtos' é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtdProduto.Focus();
                return;
            }

            try
            {
                
                decimal custo = decimal.Parse(txtCusto.Text);
                decimal precoVenda = decimal.Parse(txtPrecoVenda.Text);
                int quantidadeProduto = int.Parse(txtQtdProduto.Text);


                decimal totalCusto = custo * quantidadeProduto;
                decimal totalPrecoVenda = precoVenda * quantidadeProduto;


                decimal lucroBruto = totalPrecoVenda - totalCusto;
                decimal margemLucro = (lucroBruto / totalPrecoVenda) * 100;

                lblLucroBruto.Text = $"R$ {lucroBruto:F2}";
                lblMargemLucro.Text = $"{margemLucro:F2}%";
                lblCustoTotal.Text = $"R${totalCusto:F2}";
                lblFaturamento.Text = $"R${totalPrecoVenda:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblMargemLucro_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtQtdProduto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
