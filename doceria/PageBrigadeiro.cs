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
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";

        public PageBrigadeiro()
        {
            InitializeComponent();
        }

        private void PageBrigadeiro_Load(object sender, EventArgs e)
        {
            PageCarrinho pageCarrinho = new PageCarrinho();
            pageCarrinho.Show();
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
            if (!int.TryParse(txtQuantidade.Text.Trim(), out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida de caixas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dados para o banco
            string sabor = cmbSabor.SelectedItem.ToString();
            decimal precoCaixa = 10.00m;

            // CONEXÃO COM O BANCO
            string connectionString = @"Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno;"; // Substitua por sua string real

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO CarrinhoBrigadeiro (Sabor, QuantidadeCaixas, PrecoCaixa) VALUES (@sabor, @quantidade, @preco)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@sabor", sabor);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@preco", precoCaixa);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Sucesso
                MessageBox.Show($"{quantidade} caixa(s) de {sabor} foram adicionadas ao carrinho!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa campos
                cmbSabor.SelectedIndex = -1;
                txtQuantidade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar ao carrinho:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerCarrinho_Click(object sender, EventArgs e) //visualiza o carrinho após adicionar
        {
            PageCarrinho pagecarrinho = new PageCarrinho();
            pagecarrinho.Show();
        }
    }
}



