using Decorator.Contracts;
using System;

namespace Decorator.DomainModel.Decorators.Contracts
{
    //É a arma mais acessorios
    public abstract class ArmaDecorator
    {
        private IArma _arma;
        public ArmaDecorator(IArma arma)
        {
            _arma = arma;
        }

        //Virtal quer dizer que pode ser modificada pelo filho
        public virtual void Montar()
        {
            _arma.Montar();
        }

    }
}
