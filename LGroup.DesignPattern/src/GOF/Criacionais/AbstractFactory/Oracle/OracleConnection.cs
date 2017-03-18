using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Oracle
{
    public class OracleConnection : IDbConnection
    {
        public void Close()
        {
            Console.WriteLine("Oracle - Fechado");
        }

        public void Open()
        {
            Console.WriteLine("Oracle - Aberto");
        }
    }
}
