using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.JeitoErrado
{
    public class Produto
    {

        public Produto()
        {

        }
        public Produto(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
        public decimal Preco { get; set; }
    }
}
