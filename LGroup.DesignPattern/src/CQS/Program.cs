using CQS.JeitoCerto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo cliente => FileStoreComplemento2
            Exemplo1();
            //Exemplo cliente => FileStoreComplemento3
            Exemplo2();

        }

        public static void Exemplo1()
        {
            var fileStore = new FileStoreComplemento2("C:/");

            int idFile = 123;

            string message = string.Empty;

            bool result = fileStore.TryRead(idFile, out message);

            if (result)
                Console.WriteLine(message);
            else
                Console.WriteLine("Não existe");

            Console.ReadKey();
        }


        public static void Exemplo2()
        {
            var fileStore = new FileStoreComplemento3("C:/");

            int idFile = 123;

            var result = fileStore.Read(idFile);

            if (result.Any())
                foreach (var res in result)
                    Console.WriteLine(res);
            else
                Console.WriteLine("Não existe");

            Console.ReadKey();
        }
    }
}
