using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class RegistroFuncionarios : Form
    {
        private SqlConnection conexao;
		string strCon = "Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno;";

        public RegistroFuncionarios()
        {
			
            InitializeComponent();
        }

        public RegistroFuncionarios(int gestorId)
        {
			InitializeComponent();

			conexao = new SqlConnection(strCon);
		}

        private void RegistroFuncionarios_Load(object sender, EventArgs e)
        {
			//  esta linha de código carrega dados na tabela 'cJ3027571PR2DataSet1.Funcionarios'.
			this.funcionariosTableAdapter.Fill(this.cJ3027571PR2DataSet1.Funcionarios);
			string connectionString = "Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno;";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
			string nome = txtNome.Text.Trim();
			string cargo = txtCargo.Text.Trim();
			string salarioTexto = txtSalario.Text.Trim();

			if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(salarioTexto))
			{
				MessageBox.Show("Preencha todos os campos.");
				return;
			}

			if (!decimal.TryParse(salarioTexto, NumberStyles.Number, new CultureInfo("pt-BR"), out decimal salario))
			{
				MessageBox.Show("Salário inválido.");
				return;
			}

			using (SqlConnection conn = new SqlConnection(strCon))
			{
				string query = "INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES (@Nome, @Cargo, @Salario)";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@Nome", nome);
				cmd.Parameters.AddWithValue("@Cargo", cargo);
				cmd.Parameters.AddWithValue("@Salario", salario);

				try
				{
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Funcionário cadastrado com sucesso!");
					CarregarDados();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: " + ex.Message);
				}
			}
		}

		private void CarregarDados()
		{
			using (SqlConnection conn = new SqlConnection(strCon))
			{
				string query = "SELECT * FROM Funcionarios";
				SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
				DataTable dt = new DataTable();

				try
				{
					adapter.Fill(dt);
					dgvDados.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao carregar dados: " + ex.Message);
				}
			}
		}

		private void LimparCampos()
		{
			txtNome.Clear();
			txtCargo.Clear();
			txtSalario.Clear();
			txtNome.Focus();
		}

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
