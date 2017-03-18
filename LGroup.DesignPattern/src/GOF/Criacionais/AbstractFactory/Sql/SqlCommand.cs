using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sql
{
    public class SqlCommand : IDbCommand
    {
        public void ExecuteQuery(string query)
        {
            //A chamada
            Console.WriteLine($"Sql: {query}");
        }
    }
}
