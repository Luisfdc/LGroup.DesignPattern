using DependecyInversion.JeitoCerto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sempre programe para interface, nunca para classes  concretas
            var sql = new SqlConnection();
            var oracle = new OracleConnection();

            var clientSql = new ClienteConnection(sql);

            var clientOracle = new ClienteConnection(oracle);

            clientSql.Open();

            clientSql.Close();

            clientOracle.Open();

            clientOracle.Close();

        }
    }
}
