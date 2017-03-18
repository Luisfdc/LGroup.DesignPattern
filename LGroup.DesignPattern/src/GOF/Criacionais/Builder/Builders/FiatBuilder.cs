using Builder.Contracts;
using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class FiatBuilder : MotadoraBuilder
    {
        public override void BuildAdicionais(bool tem)
        {
            Carro.Adicionais = new Adicionais();
            if (!tem)
                base.Carro.Adicionais.Total = 0;
        }

        public override void BuildAno(int ano)
        {
            Carro.Ano = ano;
            if (ano > 2016)
                base.Carro.Preco *= 1.3M;
        }

        public override void BuildCor(string cor)
        {
            Carro.Cor = cor;
            if (cor == "branca")
                base.Carro.Preco *= 0.97M;
        }

        public override void BuildLicenciamento(bool tem)
        {
            Carro.Licenciamento = new Licenciamento();
            if (!tem)
                base.Carro.Licenciamento.Total = 0;
        }

        public override void BuildMotor(string tipo)
        {
            Carro.Motor = tipo;

            if (tipo == "V3")
                base.Carro.Preco += 100M;
            else if (tipo == "V4")
                base.Carro.Preco += 200M;
            else if (tipo == "V5")
                base.Carro.Preco += 300M;
            else 
                base.Carro.Preco += 400M;
        }

        public override void BuildPreco(decimal preco)
        {
            base.Carro.Preco = preco;
        }
    }
}
