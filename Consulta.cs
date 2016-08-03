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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void cad_UsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_UsuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_BibliotecarioDataSet);

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistema_BibliotecarioDataSet.Cad_Usuarios' table. You can move, or remove it, as needed.
            this.cad_UsuariosTableAdapter.Fill(this.sistema_BibliotecarioDataSet.Cad_Usuarios);

        }

        private void cad_UsuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.ObterConexao();
            SqlCommand cmdsql;
            cmdsql = new SqlCommand("DELETE FROM Cad_UsuariosWHERE Id_Usuario="+ conn);
            cmdsql.ExecuteNonQuery();
            MessageBox.Show("Eliminado com Sucesso");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.ObterConexao();
            SqlCommand cmdsql = new SqlCommand("UPDATE Cad_Usuarios SET Nome ,Data_de_Nascimento ,Nº_do_BI ,Residencia,Email,Telemovel,Senha ,Sexo WHERE ");
            cmdsql.ExecuteNonQuery();
            MessageBox.Show("Alteração feita com Sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro1 frm = new Cadastro1();
            frm.Show();
        }
    }
}
