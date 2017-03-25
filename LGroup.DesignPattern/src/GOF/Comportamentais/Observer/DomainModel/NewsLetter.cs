using Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DomainModel
{
    public class NewsLetter : INewsLetters
    {
        public  List<IAssinante> _assinantes;

        public NewsLetter()
        {
            _assinantes = new List<IAssinante>();
        }

        public void EnviarEmail()
        {
            _assinantes.ForEach(x => x.RecebeEmail());
        }

        public void Registrar(IAssinante assinante)
        {
            _assinantes.Add(assinante);
        }

        public void Remove(IAssinante assinante)
        {
            _assinantes.Remove(assinante);
        }
    }
}
