using Bridge.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DomainModel
{
    public class EstoqueLGroupTatuape:ILogistica
    {
        public void BaixarEstoque(int idProduto, int qtde)
        {
            Console.WriteLine($"O produto {idProduto} teve baixa de {qtde} itens.");
        }
    }
}
