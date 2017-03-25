using DomainEvents.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.ServiceLocators
{
    public class DisparadorEvento<T> where T :IDomainEvents
    {
        //Preciso localizar esse caras para enviar o evento para eles
        public static List<Type> Handlers = new List<Type>();

        static DisparadorEvento()
        {
            //1 - Preciso pegar as instacias em execução
            var types = Assembly.GetExecutingAssembly().GetTypes();

            //Precisamos saber as classes que herdam de IHandler
            foreach(var type in types)
            {
                //O tipo pode herdar de mais de uma interface
                foreach(var interf in type.GetInterfaces())
                {
                    if (interf.IsGenericType && interf.GetGenericTypeDefinition() == typeof(IHandler<>))
                    {
                        Handlers.Add(type);
                    }
                }
            }

        }

        public static void Disparar(T evento)
        {
            Handlers.ForEach(x => ((IHandler<T>)Activator.CreateInstance(x)).Handler(evento));
        }
    }

}
