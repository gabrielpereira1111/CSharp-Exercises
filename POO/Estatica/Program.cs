using System;
using Estatica.classes;

namespace Estatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.RealParaDolar(100));
            Console.WriteLine(Conversor.RealParaEuro(100));
            Console.WriteLine(Conversor.DolarParaReal(25));
            Console.WriteLine(Conversor.EuroParaReal(8));
        }
    }
}
