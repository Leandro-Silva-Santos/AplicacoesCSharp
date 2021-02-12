using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_SwitchCase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();

            novo.Show();

            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbo1.Text) {

                case "1 ou 2":
                    MessageBox.Show("Segunda-Feira", "Mensagem", MessageBoxButtons.OK);
                    break;
                case "3 ou 4":
                    MessageBox.Show("Terça-Feira", "Mensagem", MessageBoxButtons.OK);
                    break;
                case "5 ou 6":
                    MessageBox.Show("Quarta-Feira", "Mensagem", MessageBoxButtons.OK);
                    break;
                case "7 ou 8":
                    MessageBox.Show("Quinta-Feira", "Mensagem", MessageBoxButtons.OK);
                    break;
                case "9 ou 0":
                    MessageBox.Show("Sexta-Feira", "Mensagem", MessageBoxButtons.OK);
                    break;
            }
        }
    }
}
