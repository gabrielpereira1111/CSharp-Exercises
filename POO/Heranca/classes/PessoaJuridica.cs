namespace Heranca.classes
{
    public class PessoaJuridica : Pessoas
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento){
            if(documento != ""){
                return true;
            } else {
                return false;
            }
        }
    }
}