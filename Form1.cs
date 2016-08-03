using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bibliotecário_2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Cadastro1 frm = new Cadastro1();
            frm.Show();
           
            frm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emprestimo frm = new Emprestimo();
            frm.Show();
        }

        private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprestimo frm = new Emprestimo();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Devoluções frm = new Devoluções();
            frm.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devoluções frm = new Devoluções();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Consulta frm = new Consulta();
            frm.Show();
        }

       
        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livros frm = new Livros();
            frm.Show();
            this.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sobre frm = new Sobre();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ver_livros frm = new Ver_livros();
            frm.Show();
        }
    }
}
