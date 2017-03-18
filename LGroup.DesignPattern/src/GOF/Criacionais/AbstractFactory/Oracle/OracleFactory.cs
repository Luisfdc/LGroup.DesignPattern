using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Oracle
{
    public class OracleFactory : IDbFactory
    {
        public IDbCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
