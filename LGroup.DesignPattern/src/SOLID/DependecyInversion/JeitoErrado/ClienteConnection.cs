using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion.JeitoErrado
{
    //Este jeito é um jeito errado 
    //Por Varios motivos
    //1 - Faz mais do que precisa
    //2 - Se quiser colocar um novo provider teremos que modificar a classe
    //3 - Não estamos utilizando a inteface, inversão de dependencia (DIP)
    public class ClienteConnection
    {
        public void AbrirSql()
        {
            new SqlConnection().Open();
        }

        public void AbrirOracle()
        {
            new OleDbConnection().Open();
        }

        public void FecharSql()
        {
            new SqlConnection().Close();
        }


        public void FecharOracle()
        {
            new OleDbConnection().Close();
        }
    }
}
