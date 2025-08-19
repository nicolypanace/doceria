using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doceria
{
    public partial class PageCad : Form
    {
        public PageCad(PageCad pageCad)
        {
            InitializeComponent();
        }

        public PageCad()
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

            PageMenu pageMenu = new PageMenu();
            pageMenu.ShowDialog();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PageCad_Load(object sender, EventArgs e)
        {

        }
    }

}