using Decorator.Contracts;
using Decorator.DomainModel.Decorators.Contracts;

namespace Decorator.DomainModel.Decorators.Arma
{
    public class ArmaComSilenciador : ArmaDecorator
    {

        private IArma _arma;
        public ArmaComSilenciador(IArma arma)
            : base(arma)
        {
            _arma = arma;
        }

        public override void Montar()
        {
            //Adicionar algo
            //no caso um silenciador
            _arma.Nome += " => Adicionei um silenciador na arma existe \n";
        }
    }
}
