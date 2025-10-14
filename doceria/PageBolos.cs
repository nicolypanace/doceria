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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace doceria
{
    public partial class PageBolos : Form
    {
		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";

		public static List<PageCarrinho> Carrinho = new List<PageCarrinho>();
		public PageBolos()
        {
            InitializeComponent();
        }

        private void PageBolos_Load(object sender, EventArgs e)
        {
			cmbSabores.Items.Clear();
			cmbSabores.Items.Add("Milho com goiabada");
			cmbSabores.Items.Add("Laranja");
			cmbSabores.Items.Add("Chocolate");
			cmbSabores.Items.Add("Cenoura");
			cmbSabores.Items.Add("Prestígio");
			cmbSabores.Items.Add("Morango");
			cmbSabores.Items.Add("Limão");
			cmbSabores.Items.Add("Maracujá");
		}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btfinalizar_Click(object sender, EventArgs e)
        {
			
		}
		// botão para abrir o carrinho
		private void btnVerCarrinho_Click(object sender, EventArgs e)
		{
			PageCarrinho pageCarrinho = new PageCarrinho();
			pageCarrinho.ShowDialog();
		}

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void bttadd_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (cmbSabores.SelectedItem == null)
			{
				MessageBox.Show("Selecione um sabor de bolo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
			{
				MessageBox.Show("Informe uma quantidade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string sabor = cmbSabores.SelectedItem.ToString();
			decimal precoUnitario = ObterPreco(sabor);

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string sql = "INSERT INTO Carrinho (Sabor, Quantidade, PrecoUnitario) VALUES (@sabor, @quantidade, @preco)";
					SqlCommand cmd = new SqlCommand(sql, conn);

					cmd.Parameters.AddWithValue("@sabor", sabor);
					cmd.Parameters.AddWithValue("@quantidade", quantidade);
					cmd.Parameters.AddWithValue("@preco", precoUnitario);

					conn.Open();
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show($"{sabor} foi adicionado ao carrinho!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

				cmbSabores.SelectedIndex = -1;
				txtQuantidade.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro ao adicionar ao carrinho:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private decimal ObterPreco(string sabor)
		{
			string[] simples = { "Milho com Goiabada", "Chocolate", "Laranja", "Cenoura" };
			string[] recheados = { "Prestígio", "Morango", "Limão", "Maracujá" };

			if (Array.Exists(simples, s => s == sabor))
				return 18.00m;
			else if (Array.Exists(recheados, s => s == sabor))
				return 40.00m;
			else
				return 0m;
		}
    }
}
