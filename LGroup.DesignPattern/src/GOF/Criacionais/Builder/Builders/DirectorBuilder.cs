using Builder.Contracts;
using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class DirectorBuilder
    {
        private MotadoraBuilder _montadora;

        public DirectorBuilder(MotadoraBuilder montadora)
        {
            _montadora = montadora;
        }

        //Observações para analizar depois
        //1 - O carro pode ser uma abstração
        //1 - O Builder não garante que o metodo builder vai ser chamado
        //3-  Mas se for chamado garante a integridade
        //4 -  Para garantir a chamada temos o patterb (tamplate Method)
        //TODO => Ver Depois
        public void Builder(Carro carro)
        {
            _montadora.BuildPreco(carro.Preco);
            _montadora.BuildMotor(carro.Motor);
            _montadora.BuildAno(carro.Ano);
            _montadora.BuildLicenciamento(false);
            _montadora.BuildAdicionais(true);
            _montadora.BuildCor(carro.Cor);
        }

        public Carro GetCarro()
        {
            return _montadora.GetCarro();
        }
    }
}
