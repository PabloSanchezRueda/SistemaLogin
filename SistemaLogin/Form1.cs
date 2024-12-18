using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.Connection.openConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pablo" && textBox2.Text == "1234")
            {
                Form2 form2 = new Form2();
                form2.Show();
            } else
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }
        }
    }
}
