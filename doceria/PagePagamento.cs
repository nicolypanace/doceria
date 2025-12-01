using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doceria
{
    public partial class PagePagamento : Form
    {
        public PagePagamento(TextBox txtValidade = null)
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(txtNome.Text))
			{
				MessageBox.Show("Informe o nome no cartão.");
				return;
			}

			if (txtNumero.Text.Length < 16)
			{
				MessageBox.Show("Número do cartão inválido.");
				return;
			}

			if (txtCVV.Text.Length < 3)
			{
				MessageBox.Show("CVV inválido.");
				return;
			}

			if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
			{
				MessageBox.Show("Informe um valor válido.");
				return;
			}

			// Simulação de processamento
			lblStatus.Text = "Processando pagamento...";
			lblStatus.ForeColor = System.Drawing.Color.Blue;

			// Simulação de espera
			Timer timer = new Timer();
			timer.Interval = 2000; // 2 segundos
			timer.Tick += (s, args) =>
			{
				timer.Stop();
				lblStatus.Text = "Pagamento aprovado!";
				lblStatus.ForeColor = System.Drawing.Color.Green;
			};
			timer.Start();
		}

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
