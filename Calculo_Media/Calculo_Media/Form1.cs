using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;

            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            n3 = Convert.ToDouble(txtn3.Text);

            media = (n1 + n2 + n3) / 3;

            txtmedia.Text = media.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtmedia.Text = "";
        }
    }
}
