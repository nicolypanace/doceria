using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doceria
{
    public partial class PageBrigadeiro : Form
    {
		string connectionString = @"Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno";

		public PageBrigadeiro()
        {
            InitializeComponent();
        }

        private void PageBrigadeiro_Load(object sender, EventArgs e)
        {
			// Adiciona os sabores ao ComboBox
			cmbSabor.Items.Add("Brigadeiro tradicional");
			cmbSabor.Items.Add("Brigadeiro de limão");
			cmbSabor.Items.Add("Brigadeiro de morango");
			cmbSabor.Items.Add("Brigadeiro de beijinho");
			cmbSabor.Items.Add("Brigadeiro de paçoca");
		}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btcarrinho_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
			if (cmbSabor.SelectedItem == null)
			{
				MessageBox.Show("Selecione um sabor de brigadeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
			{
				MessageBox.Show("Informe uma quantidade válida de caixas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string sabor = cmbSabor.SelectedItem.ToString();
			decimal precoCaixa = 10.00m;

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string sql = "INSERT INTO CarrinhoBrigadeiro (Sabor, QuantidadeCaixas, PrecoCaixa) VALUES (@sabor, @quantidade, @preco)";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@sabor", sabor);
					cmd.Parameters.AddWithValue("@quantidade", quantidade);
					cmd.Parameters.AddWithValue("@preco", precoCaixa);

					conn.Open();
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show($"{quantidade} caixa(s) de {sabor} foram adicionadas ao carrinho!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

				cmbSabor.SelectedIndex = -1;
				txtQuantidade.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao adicionar ao carrinho:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnVerCarrinho_Click(object sender, EventArgs e)
		{
			PageCarrinho pagecarrinho = new PageCarrinho();
			pagecarrinho.Show();
		}
	}
    }

