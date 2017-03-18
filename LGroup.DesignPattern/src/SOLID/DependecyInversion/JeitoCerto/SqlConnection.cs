using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion.JeitoCerto
{
    public class SqlConnection : IDbConnection
    {
        public void Close()
        {
            Console.WriteLine("Sql - Conexão Aberta");
        }

        public void Open()
        {
            Console.WriteLine("Sql - Conexão Aberta");
        }
    }
}
