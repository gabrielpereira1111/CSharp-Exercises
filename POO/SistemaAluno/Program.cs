using System;

namespace SistemaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.Write($"Digite o curso que o {aluno.nome} está matriculado: ");
            aluno.curso = Console.ReadLine();
            Console.Write($"Digite o RG do aluno {aluno.nome}: ");
            aluno.rg = Console.ReadLine();
            Console.Write($"Digite a idade do aluno {aluno.nome}: ");
            aluno.idade = int.Parse(Console.ReadLine());
            Console.Write($"O aluno {aluno.nome} é bolsista? s/n");
            string alunoBolsista = Console.ReadLine();
            if(alunoBolsista.Equals("s")){
                aluno.bolsista = true;
            } else if(alunoBolsista.Equals("n")){
                aluno.bolsista = false;
            }
            Console.Write($"Digite a média final do aluno {aluno.nome}: ");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            int opcao = 0;

            do
            {
                Console.WriteLine("[0] - Sair");
                Console.WriteLine("[1] - Ver média do aluno");
                Console.WriteLine("[2] - Ver mensalidade do aluno");
                Console.WriteLine(" ");
                Console.Write("Escolha a opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                switch(opcao){
                    case 1:
                        Console.WriteLine($"A média do aluno {aluno.nome} é {aluno.VerMediaFinal()}");
                        break;
                    case 2:
                        Console.WriteLine($"A mensalidade do aluno {aluno.nome} é {aluno.VerMensalidade()}");
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);

        }
    }
}
