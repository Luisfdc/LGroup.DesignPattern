using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability.JeitoCerto
{
    public class Email
    {
        private Email(string de, string para, string msg)
        {

            this.De = de;
            this.Para = para;
            this.Mensagem = msg;
        }

        public static Email Create(string de, string para, string msg)
        {
            if (string.IsNullOrWhiteSpace(de))
                throw new ApplicationException("Remetente não informado");

            if (string.IsNullOrWhiteSpace(para))
                throw new ApplicationException("Destinatário não informado");

            if (string.IsNullOrWhiteSpace(msg))
                throw new ApplicationException("Mensagem não informada");

            return new JeitoCerto.Email(de, para, msg);
        }

        public static Email CreateEmailMessagePadrao(string de, string para, string msg)
        {
            var message = "Message padrão";
            return Create(de, para, message);
        }

        public string De { get; set; }
        public string Para { get; set; }
        public string Mensagem { get; set; }

        internal void EnviarEmail()
        {
            Console.WriteLine($"De: {De}, Para: {Para}, Mensagem: {Mensagem}");
        }
    }
}
