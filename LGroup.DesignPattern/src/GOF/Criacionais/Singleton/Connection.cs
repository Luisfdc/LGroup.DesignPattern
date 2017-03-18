using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Connection
    {
        private static Connection _connection { get; set; }
        private static readonly object mutex = new object();
        private Connection()
        {

        }

        public static Connection GetInstance()
        {
            lock (mutex)
            {
                //Deste jeito sem locar esse metodo quando usado com thread não funcionará
                //Poderar crirar duas instancias mesmo com o if abaixo
                if (_connection == null)
                    _connection = new Connection();
            }
            return _connection;
        }
    }
}
