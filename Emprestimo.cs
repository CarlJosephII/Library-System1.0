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
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Emprestimo_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'sistema_BibliotecarioDataSet.Cad_Livros' table. You can move, or remove it, as needed.
            Conexao CR = new Conexao();
            this.dataGridView1.DataSource =CR.carl();

            this.cad_LivrosTableAdapter.Fill(this.sistema_BibliotecarioDataSet.Cad_Livros);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string text = textBox2.Text;

            string strconection = "Data Source=CARL_JOSEPH;Initial Catalog=\"Sistema Bibliotecario\";Integrated Security=True";

            SqlConnection conexao = new SqlConnection(strconection);
            conexao.Open();
            SqlCommand cmd = new SqlCommand("select * from Cad_Usuarios where Id_Usuario='"+text+"'",conexao);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read() == true)
            {
                textBox3.Text = read["Nome"].ToString();
            }
            else
            {
                MessageBox.Show("ID Inválido ");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
