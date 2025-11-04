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
            PageCarrinho pageCarrinho = (PageCarrinho)sender;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";
            if (cmbSabor.SelectedItem == null || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Selecione o sabor e a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string doce = "Brigadeiro";
            string sabor = cmbSabor.SelectedItem.ToString();
            int quantidade = int.Parse(txtQuantidade.Text);
            decimal ValorUnitario = 10.00m; // valor por caixa de brigadeiro

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Carrinho (TipoDoce, Sabor, Quantidade, ValorUnitario) " +
               "VALUES (@TipoDoce, @Sabor, @Quantidade, @ValorUnitario)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@TipoDoce", doce);
                    cmd.Parameters.AddWithValue("@Sabor", sabor);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@ValorUnitario", ValorUnitario);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Item adicionado ao carrinho com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar ao carrinho:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageSelect pageSelect = new PageSelect();
            pageSelect.ShowDialog();
        }
    }
}

