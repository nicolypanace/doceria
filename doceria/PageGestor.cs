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
            string user = txtUsuario.Text;
            string pass = txtSenha.Text;

            using (SqlConnection con = new SqlConnection("SUA CONNECTION STRING"))
            {
                con.Open();

                string sql = "SELECT Nome, TipoUsuario FROM Usuarios WHERE Nome=@u AND Senha=@s";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@s", pass);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Sessao.NomeUsuario = dr["Nome"].ToString();
                        Sessao.TipoUsuario = dr["TipoUsuario"].ToString();

                        // Abrir página de produtos ou painel gestor
                        if (Sessao.TipoUsuario == "Gestor")
                        {
                            PageGestor tela = new PageGestor(); // sua página principal do gestor
                            tela.Show();
                        }
                        else if (Sessao.TipoUsuario == "Funcionario")
                        {
                            PrecosProdutos tela = new PrecosProdutos(); // página onde funcionários podem editar produtos
                            tela.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                    }
                }
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
    

