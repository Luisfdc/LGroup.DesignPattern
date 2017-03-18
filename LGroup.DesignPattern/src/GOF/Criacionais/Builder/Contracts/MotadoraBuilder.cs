using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Contracts
{
    public abstract class MotadoraBuilder
    {
        protected Carro Carro { get; set; }
        protected MotadoraBuilder()
        {
            Carro = new Carro();
        }
        public abstract void BuildMotor(string tipo);
        public abstract void BuildAno(int ano);
        public abstract void BuildCor(string cor);
        public abstract void BuildAdicionais(bool tem);
        public abstract void BuildLicenciamento(bool tem);
        public abstract void BuildPreco(decimal preco);

        public Carro GetCarro()
        {
            return this.Carro;
        }
    }
}
