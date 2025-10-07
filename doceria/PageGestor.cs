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

namespace doceria
{
    public partial class PageGestor : Form
    {
        private SqlConnection conexao;
        string strCon = "Data Source=SQLexpress;Initial Catalog=CJ3027571PR2;User ID=aluno;Password=aluno;";
        public PageGestor()
        {
            InitializeComponent();
           
            conexao = new SqlConnection(strCon);
        }

        public string connectionString { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                string sql = "SELECT Id, Nome FROM Gestores WHERE Usuario = @Usuario AND Senha = @Senha";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    SqlDataReader reader = cmd.ExecuteReader();


                    RegistroFuncionarios registroFuncionarios = new RegistroFuncionarios();
                    registroFuncionarios.ShowDialog();
                }

                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }
            }
        }
    }
    

