using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion.JeitoErrado
{
    public class Pagamento
    {
        public int QtdParcela { get; set; }
        public string FormaPgto { get; set; }
        public decimal Total { get; set; }
    }
}
