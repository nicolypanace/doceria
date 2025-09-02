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
    public partial class PageCadr : Form
    {
        public PageCadr()
        {
            InitializeComponent();
        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            string nome = btnome.Text;
            string email = btemail.Text;
            string telefone = bttelefone.Text;
            string data = bttdata.Text;
            string cpf = bttcpf.Text;
            string senha = btsenha.Text;

            string conexaoString = "Server=SQLexpress;Database=CJ3027571PR2;User Id=aluno;Password=aluno;";
            string query = "INSERT INTO USUARIO VALUES (@nome,@cpf, @telefone, @data, @email, @senha)";


            try
            {
                using (SqlConnection conexao = new SqlConnection(conexaoString))
                {
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@cpf", cpf);
                        comando.Parameters.AddWithValue("@telefone", telefone);
                        comando.Parameters.AddWithValue("@data", data);
                        comando.Parameters.AddWithValue("@senha", senha);

                        comando.ExecuteNonQuery();
                        if (string.IsNullOrWhiteSpace(nome) ||
                            string.IsNullOrWhiteSpace(email) ||
                            string.IsNullOrWhiteSpace(cpf) ||
                            string.IsNullOrWhiteSpace(telefone) ||
                            string.IsNullOrWhiteSpace(senha))
                        {
                            MessageBox.Show("Por favor, preencha todos os campos antes de salvar.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message);
            }
            btnome.Clear();
            btemail.Clear();
            bttelefone.Clear();
            bttcpf.Clear();
            bttdata.Clear();
            btsenha.Clear();

            PageSelect pageSelect = new PageSelect();
            pageSelect.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
