using System;
using Heranca.classes;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();

            pessoaFisica.nome = "José";

            Console.WriteLine(pessoaFisica.DarBoasVindas(pessoaFisica.nome));
            Console.WriteLine(pessoaFisica.ValidarCPF(pessoaFisica.cpf));
        }
    }
}
