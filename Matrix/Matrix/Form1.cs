using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4];

            notas[0, 0] = 9.0;
            notas[0, 1] = 9.0;
            notas[0, 2] = 9.0;
            notas[0, 3] = 9.0;
            notas[1, 0] = 9.0;
            notas[1, 1] = 9.0;
            notas[1, 2] = 9.0;
            notas[1, 3] = 9.0;

            MessageBox.Show(notas[1,2].ToString(), "Array");
        }
    }
}
