using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sql
{
    public class SqlFactory : IDbFactory
    {
        public IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}
