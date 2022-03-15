using System;

namespace AtributosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa jorge = new Pessoa();
            jorge.name = "Jorge";
            jorge.age = 18;
            jorge.height = 180;
            jorge.weight = 85;
            Console.WriteLine($"{jorge.name} - {jorge.Run()}");

            Pessoa lucas = new Pessoa();
            lucas.name = "Lucas";
            lucas.age = 32;
            lucas.height = 175;
            lucas.weight = 90;
            Console.WriteLine($"{lucas.name} - {lucas.Run()}");
        }
    }
}
