using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability.JeitoErrado
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Email Email { get; set; }

        //Quem cuida de estoque é estoque
        public void AtualizarEstoque(Estoque estoque, int qtde)
        {
            estoque.Qtde = qtde;
        }

        //GASP => De acordo com o padrão Creator do GRASP, Não posso criar Email
        //Produto cuida de Produto ex.: Validações e etc. (SPR => tenho mais de uma responsabilidade!!)
        public void EnviarEmail(string de,string para,string msg)
        {

            Email = new Email
            {
                De = de,
                Para = para,
                Mensagem = msg
            };

            Email.EnviarEmail();

        }
    }

    public class Estoque
    {
        public Produto Produto { get; set; }
        public int Qtde { get; set; }
    }

    public class Email
    {
        public string  De { get; set; }
        public string Para { get; set; }
        public string Mensagem { get; set; }

        internal void EnviarEmail()
        {
            Console.WriteLine($"De: {De}, Para: {Para}, Mensagem: {Mensagem}");
        }
    }
}
