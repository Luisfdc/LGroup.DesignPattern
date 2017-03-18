using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion.JeitoCerto
{
    public class OracleConnection : IDbConnection
    {
        public void Close()
        {
            Console.WriteLine("Oracle - Conexão Aberta");
        }

        public void Open()
        {
            Console.WriteLine("Oracle - Conexão Aberta");
        }
    }
}
