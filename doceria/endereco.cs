using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doceria
{
    public partial class endereco : Form
    {
        public class Endereco
        {
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }

            public override string ToString()
            {
                return $"{Rua}, {Numero} - {Cidade}/{Estado}";
            }
        }
        public endereco()
        {
            InitializeComponent();
        }

        private void endereco_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRua.Text) ||
               string.IsNullOrWhiteSpace(txtNumero.Text) ||
               string.IsNullOrWhiteSpace(txtCidade.Text) ||
               string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria o endereço
            Endereco endereco = new Endereco()
            {
                Rua = txtRua.Text,
                Numero = txtNumero.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text
            };

            // Exibe o endereço salvo (pode salvar no banco, lista, etc.)
            MessageBox.Show("Endereço salvo:\n" + endereco.ToString(),
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            txtRua.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }
    }
}
