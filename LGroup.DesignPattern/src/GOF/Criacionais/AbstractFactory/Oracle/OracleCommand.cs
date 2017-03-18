using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Oracle
{
    public class OracleCommand : IDbCommand
    {
        public void ExecuteQuery(string query)
        {
            //A chamada
            Console.WriteLine($"Oracle: {query}");
        }
    }
}
