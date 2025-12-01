using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;


namespace doceria
{
    public partial class endereço : Form
    {
        public class ViaCepResponse
        {
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }

            // ViaCEP retorna {"erro": true} se o CEP não existe
            public bool Erro { get; set; }
        }

        public endereço()
        {
            InitializeComponent();
        }

        private void endereço_Load(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtCEP.Text.Length != 8)
            {
                MessageBox.Show("CEP inválido.");
                return;
            }

            try
            {
                string url = $"https://viacep.com.br/ws/{txtCEP.Text}/json/";

                using (HttpClient client = new HttpClient())
                {
                    string response = client.GetStringAsync(url);

                    var endereco = JsonSerializer.Deserialize<ViaCepResponse>(response);

                    if (endereco == null || endereco.Erro)
                    {
                        MessageBox.Show("CEP não encontrado.");
                        return;
                    }

                    txtRua.Text = endereco.Logradouro;
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Localidade;
                    txtUF.Text = endereco.Uf;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar CEP: " + ex.Message);
            }
        }
    }
}
