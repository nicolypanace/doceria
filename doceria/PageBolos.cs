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

            string connectionString = @"Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";
            if (cmbSabores.SelectedItem == null || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Selecione o sabor e a quantidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string doce = "Bolo";
            string sabor = cmbSabores.SelectedItem.ToString();
            int Quantidade = int.Parse(txtQuantidade.Text);
            decimal ValorUnitario = 18.00m; // valor por bolo

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Carrinho (TipoDoce, Sabor, Quantidade, ValorUnitario) " +
               "VALUES (@TipoDoce, @Sabor, @Quantidade, @ValorUnitario)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@TipoDoce", doce);
                    cmd.Parameters.AddWithValue("@Sabor", sabor);
                    cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

            PageCarrinho pageCarrinho = new PageCarrinho();
            pageCarrinho.Show();

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

        private void voltar_Click(object sender, EventArgs e)
        {
            PageSelect pageSelect = new PageSelect();
            pageSelect.ShowDialog();
        }
    }
}
