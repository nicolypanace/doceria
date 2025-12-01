using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace doceria
{
    public partial class PageLogin : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

        public PageLogin()
        {
            InitializeComponent();
        }

        private void btenter2_Click(object sender, EventArgs e)
        {
            string email = bttemail.Text;
            string senha = btsenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM usuario WHERE EMAIL = @Email AND SENHA = @Senha";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        PageSelect pageSelect = new PageSelect();
                        pageSelect.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }


      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageComeco pageComeco = new PageComeco();
            pageComeco.ShowDialog();
        }
    }
}
