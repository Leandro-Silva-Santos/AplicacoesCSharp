using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtn.Text = " ";
            listtabuada.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 1;
            numero = int.Parse(txtn.Text);
            while (i <= 10)
            {
                resultado = i * numero;

                listtabuada.Items.Add(String.Concat(numero, "  *  ", i, "  =  ", resultado));
                i = i + 1;
            
            }
        }
    }
}
