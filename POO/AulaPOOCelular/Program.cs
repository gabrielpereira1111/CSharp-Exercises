using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            int controlPanelOption;
            
            do{
                Console.WriteLine("---------------------------------");
                Console.WriteLine("  Painel de Controle - Celular   ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("  [1] - Ligar                    ");
                Console.WriteLine("  [2] - Enviar Mensagem          ");
                Console.WriteLine("  [3] - Ligar para alguém        ");
                Console.WriteLine("  [4] - Desligar                 ");
                Console.WriteLine("=================================");
                Console.WriteLine($"Status do Celular  {celular.isOn}");
                controlPanelOption = int.Parse(Console.ReadLine());

                switch(controlPanelOption){
                    case 1:
                        Console.WriteLine(celular.TurnOn());
                        break;
                    case 2:
                        Console.WriteLine(celular.SendMessage());
                        break;
                    case 3:
                        Console.WriteLine(celular.Call());
                        break;
                    case 4:
                        Console.WriteLine(celular.TurnOff());
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }


            } while(true);
        }
    }
}
