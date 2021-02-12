using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpeso.Text = "";
            txtaltura.Text = "";
            txtimc.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            imc = peso / (altura * altura);

            txtimc.Text = imc.ToString();


            if (imc < 18.49) {
                MessageBox.Show("Você está abaixo do peso", "Situação", MessageBoxButtons.OK);
            }

            else if (imc >= 18.49 && imc <= 24.99) {
                MessageBox.Show("Você está com peso dentro da normalidade", "Situação", MessageBoxButtons.OK);
            }

            else if (imc > 24.99 && imc <= 29.99) {
                MessageBox.Show("Você está acima do peso", "Situação", MessageBoxButtons.OK);
            }
            else if (imc > 29.99 && imc <= 34.99)
            {
                MessageBox.Show("Atenção! Você está com Obesidade Grau I", "Situação", MessageBoxButtons.OK);
            }
            else if (imc > 34.99 && imc <= 39.99)
            {
                MessageBox.Show("Atenção! Você está com Obesidade Grau II (severa)", "Situação", MessageBoxButtons.OK);
            }
            else if (imc > 39.99)
            {
                MessageBox.Show("Atenção! Você está com Obesidade Grau III (mórbida)", "Situação", MessageBoxButtons.OK);
            }
        }
    }
}
