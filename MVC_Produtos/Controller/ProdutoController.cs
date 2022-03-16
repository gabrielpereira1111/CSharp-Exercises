using System.Collections.Generic;
using MVC_Produtos.Model;
using MVC_Produtos.View;

namespace MVC_Produtos.Controller
{
    public class ProdutoController
    {
        Produto p = new Produto();
        ProdutoView pv = new ProdutoView();

        public void Mostrar(){
            List<Produto> listaProdutos = p.Ler();
            pv.Listar(listaProdutos);
        }

        public void CadastrarProduto(){
            p.InserirProduto(pv.Cadastrar());
        }

    }
}