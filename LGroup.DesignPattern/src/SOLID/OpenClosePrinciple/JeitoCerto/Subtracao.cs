using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.JeitoCerto
{
    public class Subtracao : IOperacacao
    {
        public decimal NumA { get; set; }
        public decimal NumB { get; set; }
        public decimal Operar()
        {
            return NumA - NumA;
        }
    }
}
