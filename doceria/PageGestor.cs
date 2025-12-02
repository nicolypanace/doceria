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
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // -------------------------------------------
            // 1. GESTOR CRIADOR (LOGIN SUPERUSER)
            // -------------------------------------------
            if (usuario == "gestor" && senha == "123")
            {
                MessageBox.Show("Bem-vindo, gestor!");
                new RegistroFuncionarios().Show();  // Página do gestor
                this.Hide();
                return;
            }

            // -------------------------------------------
            // 2. LOGIN NORMAL (BANCO DE DADOS)
            // -------------------------------------------
            try
            {
                using (SqlConnection con = Conexao.Conectar())
                {
                    string sql = @"SELECT Nome, Cargo 
                           FROM Funcionarios 
                           WHERE Usuario = @usuario AND Senha = @senha";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string nome = dr["Nome"].ToString();
                        string cargo = dr["Cargo"].ToString();

                        MessageBox.Show("Bem-vindo, " + nome + "!");

                        if (cargo == "Gestor")
                        {
                            new RegistroFuncionarios().Show();
                        }
                        else
                        {
                            new PrecosProdutos().Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PageComeco pageComeco = new PageComeco();
            pageComeco.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

