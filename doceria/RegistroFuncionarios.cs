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

        private string connectionString;

        public int GestorId { get; }

        public RegistroFuncionarios()
        {
            conexao = new SqlConnection(connectionString);
            InitializeComponent();
        }

        public RegistroFuncionarios(int gestorId)
        {
            GestorId = gestorId;
        }

        private void RegistroFuncionarios_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno;";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cargo = txtCargo.Text.Trim();
            string salarioTexto = txtSalario.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cargo) || string.IsNullOrWhiteSpace(salarioTexto))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            // Substitui vírgula por ponto se necessário
            salarioTexto = salarioTexto.Replace(",", ".");

            decimal salario;

            try
            {
                salario = Convert.ToDecimal(salarioTexto, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Salário inválido. Use ponto como separador. Ex: 2500.75");
                return;
            }

            try
            {
                conexao.Open();
                string query = "INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES (@Nome, @Cargo, @Salario)";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Cargo", cargo);
                cmd.Parameters.AddWithValue("@Salario", salario);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário adicionado com sucesso!");
                txtNome.Clear();
                txtCargo.Clear();
                txtSalario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void LimparCampos()
        {
            txtNome.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}