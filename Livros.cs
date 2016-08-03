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
    public partial class Livros : Form
    {
        public Livros()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Livros_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir esse livro?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                
            
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = Conexao.ObterConexao();
            if (sql == null)
            {
                MessageBox.Show("Erro na Conexão");
                return;
            }

            String INSERIR = ("INSERT INTO Cad_Livros (Titulo,Edicao,Autor,Ano_de_Lancamento,comentario)VALUES (' " + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "', '"+Convert.ToInt32 (textBox3.Text)+ "','" + textBox4.Text + "')"), conn;


          SqlCommand comando = new SqlCommand(INSERIR, sql);
          comando.ExecuteNonQuery();
          MessageBox.Show("Cadastrado com Sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1 ();
            frm.Visible=true;
            this.Close();
        }
    }
}
