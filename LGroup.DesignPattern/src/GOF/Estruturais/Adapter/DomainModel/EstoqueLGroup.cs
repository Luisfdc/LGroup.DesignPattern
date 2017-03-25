using Adapter.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DomainModel
{
    //Este aqui é nosso dominio, nosso modelo de negócio
    public class EstoqueLGroup : ILogistica
    {
        public void BaixarEstoque(int idProduto, int qtde)
        {
            Console.WriteLine($"O produto {idProduto} teve baixa de {qtde} de itens.");
        }
    }
}
