using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtusuario.Text;
            senha = txtsenha.Text;


            if (usuario == "admin" && senha == "1234") {
                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false;
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário: admin. Senha: 1234");
        }
    }
}
