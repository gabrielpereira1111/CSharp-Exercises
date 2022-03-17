using MVC_Jogos.Model;
using MVC_Jogos.View;

namespace MVC_Jogos.Controller
{
    public class JogosController
    {
        Jogos jogos = new Jogos();
        JogosView jogosView = new JogosView();

        public void Listar(){
            jogosView.ListarTodos(jogos.Ler());
        }

        public void Cadastrar(){
            jogos.InserirJogo(jogosView.InserirJogo());
        }
    }
}