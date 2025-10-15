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
    public partial class PageDonuts : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";
        public PageDonuts()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			PageCarrinho pagecarrinho = new PageCarrinho();
			pagecarrinho.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";
            if (cmbSabor.SelectedItem == null || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Selecione o sabor e a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sabor = cmbSabor.SelectedItem.ToString();
            int quantidade = int.Parse(txtQuantidade.Text);
            decimal ValorUnitario = 18.00m; // valor por caixa de donuts
            decimal ValorTotal = ValorUnitario * quantidade;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Carrinho (TipoDoce, Sabor, Quantidade, ValorUnitario, Valor Total) VALUES (@TipoDoce, @Sabor, @Quantidade, @ValorUnitario, @Valor Total)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TipoDoce", "Donuts");
                    cmd.Parameters.AddWithValue("@Sabor", sabor);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@ValorUnitario", ValorUnitario);
                    cmd.Parameters.AddWithValue("@Valor Total", ValorTotal);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Item adicionado ao carrinho com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerCarrinho_Click(object sender, EventArgs e)
        {
            PageCarrinho carrinho = new PageCarrinho();
            carrinho.Show();
        }
    }
}