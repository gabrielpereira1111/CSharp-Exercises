namespace Encapsulamento.classes
{
    public class Cartao
    {
        string numero;
        string bandeira;

        public string BB{
            get {return bandeira;} // O GET DIZ QUE EU POSSO LER O ATRIBUTO 'bandeira'
            set {bandeira = value;} // O SET DIZ QUE POSSO ATRIBUIR ALGUM VALOR AO ATRIBUTO 'bandeira'
        }
        protected string token = "qwertyui";
        public string Token{
            get{return token;}
        }
        int cvv;
        public int Cvv{
            get{return cvv;}
            set{cvv = value;}
        }
        protected float limite = 5000;

        protected string ValidarToken(string token){
            if(token == this.token){
                return "Token validado";
            }
            return "Token inválido";
        }

        public string RegistrarCompra(bool validado){
            return "";
        }

        private bool ValidarCompra(float saldo){
            return false;
        }
    }
}