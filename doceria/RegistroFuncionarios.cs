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
        private DataTable dtFuncionarios;
        private int selectedId = -1;
        public RegistroFuncionarios()
        {
            this.Load += RegistroFuncionarios_Load;
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
        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDados.Rows[e.RowIndex];

                idSelec = Convert.ToInt32(row.Cells["Id"].Value);
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtCargo.Text = row.Cells["Cargo"].Value.ToString();
                txtSalario.Text = row.Cells["Salario"].Value.ToString();
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um funcionário na tabela para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text.Trim();
            string cargo = txtCargo.Text.Trim();
            string salarioTexto = txtSalario.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(salarioTexto))
            {
                MessageBox.Show("Preencha todos os campos antes de editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(salarioTexto, out decimal salario))
            {
                MessageBox.Show("Salário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                string query = "UPDATE Funcionarios SET Nome = @Nome, Cargo = @Cargo, Salario = @Salario WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Cargo", cargo);
                    cmd.Parameters.AddWithValue("@Salario", salario);
                    cmd.Parameters.AddWithValue("@Id", idSelecionado);

                    try
                    {
                        conn.Open();
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                            MessageBox.Show("Funcionário atualizado com sucesso!");
                        else
                            MessageBox.Show("Nenhum funcionário foi atualizado (verifique o ID).");

                        CarregarDados(); // Atualiza o DataGridView
                        LimparCampos();  // Limpa os campos
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar funcionário: " + ex.Message);
                    }
                }
            }
        }
    }
}
