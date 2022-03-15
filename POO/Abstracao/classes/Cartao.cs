namespace Abstracao.classes
{
    public class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCartao(){
            return "";
        }
        public override string Desconto(int valor)
        {
            return "";
        }
    }
}