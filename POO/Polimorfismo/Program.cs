using System;
using Polimorfismo.classes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*.*/
            /*.*/
            MegaMan m = new MegaMan();
            Console.WriteLine("MegaMan:");
            // Como esse método pelo MegaMan foi sobreescrito(override), ele vai ser diferente do "Correr" do Zero
            Console.WriteLine(m.Correr());
            Console.WriteLine(m.Pular());

            Console.WriteLine(" ");

            Zero z = new Zero();
            Console.WriteLine("Zero:");
            Console.WriteLine(z.Correr());
            //Como esse método foi sobreescrito pelo Zero, ele vai ser diferente do "Pular" do MegaMan
            Console.WriteLine(z.Pular());
        }
    }
}
