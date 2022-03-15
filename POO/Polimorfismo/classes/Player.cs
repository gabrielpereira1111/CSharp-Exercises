namespace Polimorfismo.classes
{
    public abstract class Player
    {
        float velocidade;
        float forcaPulo;

        public virtual string Correr(){
            return "Você está correndo em 1x";
        }

        public virtual string Pular(){
            return "Você está pulando 1 bloco";
        }
        
    }
}