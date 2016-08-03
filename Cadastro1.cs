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
    public partial class Cadastro1 : Form
    {
        
        public Cadastro1()
        {
            InitializeComponent();
        }
        private SqlConnection conn=Conexao.conn;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
          

            SqlConnection sql = Conexao.ObterConexao();
            
            if (sql == null)
            {
                MessageBox.Show("Erro na conexao");
                return;
            }

            string INSERIR=("INSERT INTO Cad_Usuarios(Nome,Data_de_Nascimento,Nº_do_BI,Residencia,Email,Telemovel,Senha,Sexo,Foto)"+
                "values ('" +textBox2.Text+"','" + comboBox1.Text + "-" + comboBox2.Text + "-" + comboBox3.Text + "','" +textBox4.Text+"', '" + textBox5.Text+"','" +textBox6.Text+"','"+Convert.ToInt32(textBox7.Text)+"','"+textBox8.Text+"','" + radioButton1.Checked+"','" + pictureBox1+"')"), conn;

                SqlCommand comando=new SqlCommand(INSERIR,sql);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com Sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files|*.jpg;*.png;*.gif";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.Cancel)
                return;
           pictureBox1.Image= Image.FromFile(ofd.FileName);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastro1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Limpar os campos preenchidos
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            

        }
    }
}
