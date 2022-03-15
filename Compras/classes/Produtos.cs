namespace Compras.classes
{
    public class Produtos
    {
        public Produtos(){

        }

        public Produtos(int _codigo, string _nome, float _preco){
            Codigo = _codigo;
            Nome = _nome;
            Preco = _preco;
        }
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        
    }
}