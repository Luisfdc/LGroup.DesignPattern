using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion.JeitoErrado
{
    //Padrão active records
    public class Carrinho
    {
        private IConnection _connection;
        private ICommand _command;
        public Carrinho(IConnection connection, ICommand command)
        {
            _connection = connection;
            _command = command;
        }

        public Pedido Pedido { get; set; }
        public List<ItensCarrinho> Itens { get; set; }

        public void CriarPedido()
        {

            //Provavelmente ira ter um a factory 
            //para criar a instancia do pedido baseado no carrinho

            _connection.Open();

            _command.Execute(_connection, "insert into ....");

            _connection.Close();
        }
    }
}
