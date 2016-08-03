using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Bibliotecário_2013
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "CARL JOSEPH") && (textBox2.Text == "1234"))
            {
                // Chama o outro Formulário

                Form1 frm = new Form1();
                frm.Show();
                //Ocultando

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Invalidas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)

        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}