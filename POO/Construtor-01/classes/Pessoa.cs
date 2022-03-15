namespace Construtor_01.classes
{
    public class Pessoa
    {
        private string nome;
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }

        private string sobreNome;
        public string SobreNome{
            get{return sobreNome;}
            set{sobreNome = value;}
        }

        public Pessoa(string firstName, string lastName){
            nome = firstName;
            sobreNome = lastName;
        }

        public Pessoa(){
            
        }
    }
}