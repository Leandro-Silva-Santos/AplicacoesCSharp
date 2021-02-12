using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Aritmetica
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

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            resultado = n1 - n2;
            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txtresultado.Text = "";

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            resultado = n1 + n2;
            txtresultado.Text = resultado.ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            resultado = n1 * n2;
            txtresultado.Text = resultado.ToString();

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            resultado = n1 / n2;
            txtresultado.Text = resultado.ToString();

        }
    }
}
