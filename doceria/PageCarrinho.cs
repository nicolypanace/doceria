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
using doceria.WinFormsNavegacaoSimples;

namespace doceria
{
    public partial class PageCarrinho : Form
	{
		string connectionString = @"Data Source= SQLEXPRESS;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";

		public int Quantidade { get; set; }
		public decimal PrecoUnitario { get; set; }
		public decimal Subtotal => Quantidade * PrecoUnitario;
		public PageCarrinho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void PageCarrinho_Load(object sender, EventArgs e)
		{
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT TipoDoce, Sabor, Quantidade, ValorUnitario, ValorTotal FROM Carrinho";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar carrinho: " + ex.Message);
            }
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";

            string sql = @"
        SELECT 
            'Brigadeiro' AS Tipo,
            Sabor AS Produto,
            QuantidadeCaixas AS Quantidade,
            PrecoCaixa AS Preco
        FROM CarrinhoBrigadeiro
        UNION ALL
        SELECT 
            'Bolo' AS Tipo,
            Sabores AS Produto,
            Quantidade,
            Preco
        FROM CarrinhoBolos;
    ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o carrinho final:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageSelect telaAnterior = new PageSelect(); 
            telaAnterior.Show();
            this.Close(); // Fecha a tela atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
        endereco endereco = new endereco();
        }

        private void dgvCarrinho_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            endereco endereco = new endereco(); 

        }
    }
}