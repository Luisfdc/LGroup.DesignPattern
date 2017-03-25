using Composite.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.DomainModel.Services
{
    //Esta classe ira formar qualquer servico de formatação que você precisar
    //Com o auxilio das classes existentes, iremos gerar todos os tipos de formatação que quisermos
    public class FormatacaoGeralService : IFormatacao
    {
        private List<IFormatacao> _formatacoes;

        public FormatacaoGeralService()
        {
            _formatacoes = new List<IFormatacao>();
        }

        public void Adicionar(IFormatacao formatacao)
        {
            _formatacoes.Add(formatacao);
        }

        public void Remover(IFormatacao formatacao)
        {
            _formatacoes.Remove(formatacao);
        }

        public void Formatar()
        {
            _formatacoes.ForEach(x => x.Formatar());
        }
    }
}
