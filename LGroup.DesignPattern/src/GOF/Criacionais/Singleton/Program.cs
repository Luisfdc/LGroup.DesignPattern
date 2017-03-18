using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var connect1 = Connection.GetInstance();

            var connect2 = Connection.GetInstance();

            if (connect1.GetHashCode().Equals(connect2.GetHashCode()))
            {
                Console.WriteLine($"{connect1.GetHashCode()}{connect2.GetHashCode()}");
            }


            if (connect1.Equals(connect2))
            {
                Console.WriteLine($"1");
            }

            var connetc3 = Connection2.Connection;
            var connect4 = Connection3.GetInstance();

            Console.ReadKey();
        }
    }
}
