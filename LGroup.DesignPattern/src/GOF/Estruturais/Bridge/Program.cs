using Bridge.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente A
            var estoqueLGroupTatuape = new EstoqueLGroupTatuape();
            estoqueLGroupTatuape.BaixarEstoque(1, 1);

            //Passou um tempo e o cliente A quer um cerviço do tatuapé mas com alta disponibilidade


            var estoqueLGroupTatuapeAd = new EstoqueLGroupAltaDisponibilidade(estoqueLGroupTatuape);

            for (int i = 1; i <= 10; i++)
                estoqueLGroupTatuapeAd.BaixarEstoqueComAltaDisponibilidade(i, 1);

            Console.ReadKey();
        }
    }
}
