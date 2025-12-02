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
using doceria; // MUITO IMPORTANTE
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
            string sql = "SELECT Nome, TipoUsuario FROM usuario WHERE TipoUsuario = @TipoUsuario AND Senha = @Senha";

            string tipoUsuario = "gestor";
            string senha = "123";

            SqlCommand cmd = new SqlCommand(sql, conexao); // <-- aqui está a correção

            cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                conexao.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string nome = dr["Nome"].ToString();
                    string cargo = dr["TipoUsuario"].ToString();

                    MessageBox.Show("Bem-vindo, " + nome + "!");
                    RegistroFuncionarios registroFuncionarios = new RegistroFuncionarios();
                    registroFuncionarios.Show();

                    if (cargo == "Gestor")
                    {
                        new RegistroFuncionarios().Show();
                    }
                    else
                    {
                     
                    }
                   
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }

                conexao.Close();
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
    

