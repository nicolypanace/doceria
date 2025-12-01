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
    public partial class FormEndereco : Form
    {
        string conexaoString = "Server=SQLexpress;Database=CJ3027571PR2;User Id=aluno;Password=aluno;";
        // Removido ID externo — agora o formulário salva diretamente no banco
        private int? _clienteId = null;


        public FormEndereco(int? clienteId = null)
        {
            InitializeComponent();


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string endereco = txtEndereco.Text.Trim();

            if (string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Digite um endereço!", "Atenção");
                return;
            }

            try
            {
                // Sua conexão com o SQL Express
                string conexaoString = "Server=SQLexpress;Database=CJ3027571PR2;User Id=aluno;Password=aluno;";

                using (SqlConnection conn = new SqlConnection(conexaoString))
                {
                    conn.Open();

                    string query = "INSERT INTO Clientes (Endereco) VALUES (@Endereco)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Endereco", endereco);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Endereço salvo com sucesso!");
                txtEndereco.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 