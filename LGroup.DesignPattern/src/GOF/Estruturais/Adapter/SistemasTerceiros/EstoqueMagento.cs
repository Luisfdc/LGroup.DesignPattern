using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.SistemasTerceiros
{
    //Poderia ser uma API, um WebService Soap
    public class EstoqueMagento
    {
        public void Baixar(int idProduto, int qtde)
        {
            Console.WriteLine($"O produto {idProduto} teve baixa de {qtde} de itens.");
        }
    }
}
