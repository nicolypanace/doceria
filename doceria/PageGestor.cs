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
    public partial class PageGestor : Form
    {
        public PageGestor()
        {
            InitializeComponent();
        }

        public string connectionString { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, Nome FROM Gestores WHERE Usuario = @Usuario AND Senha = @Senha";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int gestorId = reader.GetInt32(0);
                        string nomeGestor = reader.GetString(1);

                        MessageBox.Show($"Bem-vindo, {nomeGestor}!");

                        RegistroFuncionarios registrofuncionarios = new RegistroFuncionarios(gestorId);
                        registrofuncionarios.Show();

                        this.Hide(); 
                        RegistroFuncionarios registroFuncionarios = new RegistroFuncionarios();
                        registroFuncionarios.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }
                }
            }
        }
    }
}
    

