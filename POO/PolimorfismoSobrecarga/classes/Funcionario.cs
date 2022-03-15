using System;

namespace PolimorfismoSobrecarga.classes
{
    public class Funcionario
    {
        public string[] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda"};

        public void Mostrar(){
            foreach(var item in lista){
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice){
            Console.WriteLine(lista[indice]);
        }

        public void Mostrar(string nome){
            foreach(var item in lista){
                if(item == nome){
                    Console.WriteLine("O nome existe no array");
                } 
            }
        }
    }
}