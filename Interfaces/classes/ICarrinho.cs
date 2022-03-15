namespace Interfaces.classes
{
    public interface ICarrinho
    {
         void Listar();
         void Cadastrar(Produtos novoProduto);
         void Deletar(Produtos produtos);
         void Alterar(int codigo, Produtos novoProduto);
    }
}