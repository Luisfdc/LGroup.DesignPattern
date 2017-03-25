using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamplateMethod.Contracts;

namespace TamplateMethod.DomainModel
{
    public class VendasCasasBahia : VendaTamplate
    {
        private Random _random;
        public VendasCasasBahia()
        {
            _random = new Random();
        }
        protected override void DarBaixa()
        {
            Console.WriteLine("Baixa no estoque");
        }

        protected override bool EfetuarPagamento()
        {
            return _random.Next(0, 100) <= 80;
        }

        protected override bool Estoque()
        {
            return _random.Next(0, 100) <= 80;
        }

        protected override bool PuxarCapivara(string cpf)
        {
            return _random.Next(0, 100) <= 80;
        }
    }
}
