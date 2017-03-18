using ReflectionFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionFactory.Factory
{
    public static class DesenhoFactory
    {
        public static IDesenho Create(string nome)
        {
            //Tenho que achar a classe com o nome informado e a partir do nome criar minha classe
            Assembly assembly = Assembly.GetExecutingAssembly();

            //Estou pegando o tipo da classe que corresponde ao nome informado
            var tipoDesenho = assembly.GetTypes().FirstOrDefault(x => x.Name.ToLower() == nome.ToLower());

            //Criando a instacia
            //Tenho que fazer um cast porque o createInstance retorna object
            var instance = (IDesenho)Activator.CreateInstance(tipoDesenho);
            return instance;
        }
    }
}
