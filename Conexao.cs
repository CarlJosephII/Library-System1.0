using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_Bibliotecário_2013
{
    class Conexao {
        SqlCommand DR = null;


       private string con ="SELECT [Id_Livro],[Titulo],[Ano_de_Lancamento],[Edicao],[Autor],[comentario]FROM [Sistema Bibliotecario].[dbo].[Cad_Livros]";
       

   

        private static string Consting =@"Data Source=CARL_JOSEPH;Initial Catalog=Sistema Bibliotecario;Integrated Security=True";
         public static SqlConnection conn =new SqlConnection(Consting);
    public static SqlConnection ObterConexao() 
    { 
        
        try {
            conn.Open(); 
        }
        catch (Exception)
        {
            conn = null;
        } 
        return conn;
    }
    public static void FecharConexao() 
    {
        if (conn != null)
    {
            conn.Close();
        } 
    
    } public DataTable carl()
        {
            DR = new SqlCommand(con, conn);
            SqlDataAdapter SA = new SqlDataAdapter(DR);
            DataTable DT = new DataTable();
        SA.Fill(DT);
            
            return DT;
        }
}


    }

