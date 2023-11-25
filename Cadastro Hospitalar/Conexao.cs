using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Cadastro_Hospitalar
{

    


    internal class Conexao
    {

        static string database = "Hospital";
        SqlConnection cnn = new SqlConnection();

        public static string StrCon
        {
            get { return $"Data Source={GetServerName()}\\SQLEXPRESS;Initial Catalog={database};Integrated Security=True"; }

            
        }

        static string GetServerName()
        {
            return System.Environment.MachineName;
            
        }

        //Construtor
        public Conexao()
        {

            cnn.ConnectionString = StrCon;
        }

        //Método Connect
        public SqlConnection conectar()
        {
            if(cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Open();
            }

            return cnn;
            
        }

        //Método Desconnect
        public void desconectar()
        {

            if (cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Close();
            }

            return;

        }



    }
}
