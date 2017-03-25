using Decorator.DomainModel.Decorators.Contracts;
using Decorator.Contracts;

namespace Decorator.DomainModel.Decorators.Arma
{
    public class ArmaComMira : ArmaDecorator
    {
        private IArma _arma;
        public ArmaComMira(IArma arma)
            : base(arma)
        {
            _arma = arma;
        }

        public override void Montar()
        {
            //Montar arma existente
            //Adicionar algo
            //no caso uma mira
            _arma.Nome += " => Adicionei uma mira na arma existe \n";
           
        }
    }
}
