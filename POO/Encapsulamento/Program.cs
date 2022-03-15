using System;
using Encapsulamento.classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard m = new Mastercard();

            m.BB = "MasterCard";
            Console.WriteLine(m.BB);
        }
    }
}
