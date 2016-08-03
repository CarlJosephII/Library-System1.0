using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Sistema_Bibliotecário_2013
{
    class Conexão
    {
    private static string Consting = @"Data Source=CARL_JOSEPH;Initial Catalog=Sistema Bibliotecario;Integrated Security=True";
    
    private static SqlConnection conn = null;
    public static SqlConnection ObterConexao()
    { 
        conn = new SqlConnection (Consting);
        try {
            conn.Open(); 
        }
        catch (Exception)
        {
            conn = null;
        } 
        return conn;
    
    }
public void FecharConexao() 
    {
        if (conn != null)
    {
            conn.Close();
        } 
    
    }

    }

}
       
    
    
