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
    public partial class pagecadastro : Form
    {
        public pagecadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCad_Click(object sender, EventArgs e)
        {
            PageCad pageCad = new PageCad();
            pageCad.ShowDialog();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            PageLogin pageLogin = new PageLogin();
            pageLogin.ShowDialog();
        }
    }
}
