using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Connection2
    {
        public static readonly Connection2 Connection = new Connection2();
        private Connection2() { }
        
    }
}
