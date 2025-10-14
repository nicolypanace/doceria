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
    public partial class PageCarrinho : Form
	{
		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno";

		public string Sabores { get; set; }
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

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void PageCarrinho_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'cJ3027571PR2DataSet2.Carrinho'. Você pode movê-la ou removê-la conforme necessário.
			this.carrinhoTableAdapter.Fill(this.cJ3027571PR2DataSet2.Carrinho);
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT Id, Sabor, Quantidade, PrecoUnitario, Subtotal, DataAdicionado FROM Carrinho";
				SqlDataAdapter da = new SqlDataAdapter(sql, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgvCarrinho.DataSource = dt;
			}
		}

		private void AtualizarTotal()
		{
			decimal total = PageBolos.Carrinho.Sum(item => item.Subtotal);
			lblTotal.Text = $"Total: R$ {total:F2}";
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}