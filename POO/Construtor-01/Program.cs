using System;
using Construtor_01.classes;

namespace Construtor_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Gabriel";
            pessoa.SobreNome = "Pereira";

            Console.WriteLine($"Olá, {pessoa.Nome} {pessoa.SobreNome}");

            Pessoa pessoa2 = new Pessoa("João","Silva");

            Console.WriteLine($"Olá, {pessoa2.Nome} {pessoa2.SobreNome}"); 
        }
    }
}
