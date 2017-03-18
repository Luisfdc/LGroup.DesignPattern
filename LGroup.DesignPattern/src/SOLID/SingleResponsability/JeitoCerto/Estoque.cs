using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability.JeitoCerto
{
    public class Estoque
    {
        public Produto Produto { get; set; }
        public int Qtde { get; set; }

        public void Adicionar(int qtde)
        {
            Validar(qtde);
            this.Qtde += qtde;
        }

        public void Remover(int qtde)
        {
            Validar(qtde);
            this.Qtde -= qtde;
        }

        private void Validar(int qtde)
        {

            if (qtde < 0)
                throw new ApplicationException("A quantidade deve ser maior que zero");
        }
    }
}
