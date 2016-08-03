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
    public partial class Inicial : Form
    {
        int z;

        public Inicial()
        {
            InitializeComponent();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            z = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (z < 20)
            {
                z++;
            }
            else
            {
                timer1.Stop();
                LOGIN lg = new LOGIN();
                lg.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
