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
    public partial class PrecosProdutos : Form
    {
        public PrecosProdutos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string precoText = txtPreco.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(precoText))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            if (!decimal.TryParse(precoText, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Produtos (Nome, Preco) VALUES (@Nome, @Preco)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Preco", preco);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto cadastrado com sucesso!");

                txtNome.Clear();
                txtPreco.Clear();

                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar produto: " + ex.Message);
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT Id, Nome, Preco FROM Produtos";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProdutos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }
    }
}
