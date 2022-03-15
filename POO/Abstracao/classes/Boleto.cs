namespace Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;
        public string CodigoDeBarras {
            get{return codigoDeBarras;}
        }
        
        public override string Desconto(int valor)
        {
            return "";
        }
    }
}