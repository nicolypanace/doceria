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
    public partial class PageSelect : Form
    {
        private object pageDonuts;

        public PageSelect()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        private void btbolo_Click(object sender, EventArgs e)
        {
            PageBolos pageBolos = new PageBolos();
            pageBolos.ShowDialog();
        }

        private void btdonuts_Click(object sender, EventArgs e)
        {
            PageDonuts pageDonuts = new PageDonuts();
            pageDonuts.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PageSelect_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            PageBrigadeiro pageBrigadeiro = new PageBrigadeiro();
            pageBrigadeiro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
