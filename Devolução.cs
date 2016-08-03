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
    public partial class Devoluções : Form
    {
        public Devoluções()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Devoluções_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistema_BibliotecarioDataSet1.Devolucao' table. You can move, or remove it, as needed.
            this.devolucaoTableAdapter.Fill(this.sistema_BibliotecarioDataSet1.Devolucao);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void devolucaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.devolucaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_BibliotecarioDataSet1);

        }
    }
}
