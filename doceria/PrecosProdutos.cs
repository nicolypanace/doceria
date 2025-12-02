using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doceria
{
    public partial class PrecosProdutos : Form
    {
        string conexao = "Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno;";
        public PrecosProdutos()
        {
            InitializeComponent();
        }
        private void PrecosProdutos_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno;";
        }
        private void CarregarProdutos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexao))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produtos", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridProdutos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexao))
                {
                    string query = "INSERT INTO Produtos (Nome, Preco, Quantidade) VALUES (@Nome, @Preco, @Quantidade)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Preco",
        decimal.Parse(txtPreco.Text, new CultureInfo("pt-BR")));
                    cmd.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(txtQuantidade.Text));
             
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto adicionado com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtPreco.Clear();
                txtQuantidade.Clear();

                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void gridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroFuncionarios registroFuncionarios = new RegistroFuncionarios();
            registroFuncionarios.Show();
        }
    }
}
