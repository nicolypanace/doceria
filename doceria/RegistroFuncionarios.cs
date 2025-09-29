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
    public partial class RegistroFuncionarios : Form
    {
        private string connectionString;

        public int GestorId { get; }

        public RegistroFuncionarios()
        {
            InitializeComponent();
        }

        public RegistroFuncionarios(int gestorId)
        {
            GestorId = gestorId;
        }

        private void RegistroFuncionarios_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=RegistroFuncionariosDB;Integrated Security=True";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string salarioText = txtSalario.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(salarioText))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(salarioText, out salario))
            {
                MessageBox.Show("O salário deve ser um valor numérico!");
                return;
            }


            string registro = $"{nome},{cargo},{salario}";
            {
                {
                    string Nome = txtNome.Text.Trim();
                    string Cargo = txtCargo.Text.Trim();
                    string Salario = txtSalario.Text.Trim();

                    if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(salarioText))
                    {
                        MessageBox.Show("Todos os campos são obrigatórios.");
                        return;
                    }

                    if (!decimal.TryParse(salarioText, out decimal salario))
                    {
                        MessageBox.Show("Salário inválido.");
                        return;
                    }

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "INSERT INTO Funcionarios (Nome, Cargo, Salario) VALUES (@Nome, @Cargo, @Salario)";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Nome", nome);
                                cmd.Parameters.AddWithValue("@Cargo", cargo);
                                cmd.Parameters.AddWithValue("@Salario", salario);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Funcionário registrado com sucesso!");

                        txtNome.Clear();
                        txtCargo.Clear();
                        txtSalario.Clear();

                        CarregarRegistros();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message);
                    }
                }
            }
        }

        private void CarregarRegistros()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Nome, Cargo, Salario FROM Funcionarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar registros: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
