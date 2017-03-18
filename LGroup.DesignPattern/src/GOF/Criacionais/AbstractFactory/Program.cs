using AbstractFactory.Contracts;
using AbstractFactory.Oracle;
using AbstractFactory.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFactory dbFactory = new OracleFactory();

            var connection = dbFactory.CreateConnection();
            var command = dbFactory.CreateCommand();

            connection.Open();
            command.ExecuteQuery("Select * from table");
            connection.Close();
            Console.ReadKey();
        }
    }
}
