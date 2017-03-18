using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sql
{
    public class SqlConnection : IDbConnection
    {
        public void Close()
        {
            Console.WriteLine("Sql - Fechado");
        }

        public void Open()
        {
            Console.WriteLine("Sql - Aberto");
        }
    }
}
