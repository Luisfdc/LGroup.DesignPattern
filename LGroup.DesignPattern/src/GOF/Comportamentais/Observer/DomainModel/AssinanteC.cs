using Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DomainModel
{
    public class AssinanteC : IAssinante
    {
        public void RecebeEmail()
        {
            Console.WriteLine("Assinante C recebendo email");
        }
    }
}
