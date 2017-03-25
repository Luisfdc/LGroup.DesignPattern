using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod.Contracts
{
    public abstract class VendaTamplate
    {
        public void Finalizar(string cpf)
        {
            var erros = new List<string>();

            if (string.IsNullOrWhiteSpace(cpf))
                throw new Exception("CFP Não informado");

            if (!this.PuxarCapivara(cpf)) erros.Add("Nome Sujo");

            if (!this.Estoque()) erros.Add("Sem Estoque");

            if (!this.EfetuarPagamento()) erros.Add("Erro ao gerar Pagamento");

            if (erros.Count == 0)
                this.DarBaixa();

            if (erros.Count > 0)
                Console.WriteLine(string.Join(",", erros));
        }

        protected abstract bool PuxarCapivara(string cpf);
        protected abstract bool Estoque();
        protected abstract bool EfetuarPagamento();
        protected abstract void DarBaixa();
    }
}
