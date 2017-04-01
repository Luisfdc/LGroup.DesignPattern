using System;

namespace ExemploGeral.DomainModel
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
    }

    public enum Sexo
    {
        Feminino,
        Masculino
    }
    public enum EstadoCivil
    {
        Casado,
        Solteiro,
        Viuvo,
        Divorciado,
        Amigado
    }
}
