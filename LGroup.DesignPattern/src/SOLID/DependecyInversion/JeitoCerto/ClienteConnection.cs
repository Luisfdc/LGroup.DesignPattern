using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInversion.JeitoCerto
{
    public class ClienteConnection
    {
        private IDbConnection _dbConnection;

        public ClienteConnection(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Open()
        {
            _dbConnection.Open();
        }

        public void Close()
        {
            _dbConnection.Close();
        }
    }
}
