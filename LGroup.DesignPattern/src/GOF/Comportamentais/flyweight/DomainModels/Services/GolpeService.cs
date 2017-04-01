using flyweight.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.DomainModels.Services
{
    public class GolpeService
    {
        //Container
        //Onde vou guardar minhas  classes e serviços
        //Aqui iremos indentificar uma classe por uma chave
        //Logo, este item é um container de localização de classes já instanciadas
        //Ou seja é um service locator
        public static IDictionary<string,IGolpe> _golpes;
        static GolpeService() {
            _golpes = new Dictionary<string, IGolpe>();
            _golpes.Add("cabecada", new Cabecada());
            _golpes.Add("chutefraco", new ChuteFraco());
            _golpes.Add("voadora", new Voadora());
        }

        public static IGolpe Get(string nomeGolpe)
        {
            return _golpes[nomeGolpe];
        }

    }
}
