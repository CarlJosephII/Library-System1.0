using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sistema_Bibliotecário_2013
{
    public partial class Ver_livros : Form
    {
        public Ver_livros()
        {
            InitializeComponent();
        }

      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\toshiba\Documents\materia\TLP\Logica_de_Programacao_Algoritmos_e_Estruturas_de_Dados.pdf");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\toshiba\Documents\materia\programação\tutorial_java.pdf");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\toshiba\Documents\materia\Web Designer\Flash\Flash_Curso técnico Júnior.pdf");


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\toshiba\Documents\materia\Web Designer\webpages.pdf");
        }
    }
}
