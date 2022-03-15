namespace Heranca.classes
{
    public class PessoaFisica : Pessoas
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(string documento){
            if(documento == ""){
                return true;
            } else {
                return false;
            }
        }
    }
}