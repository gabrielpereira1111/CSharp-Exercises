namespace SistemaAluno
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade = 1000;

        public float VerMediaFinal(){
            return this.mediaFinal;
        }
        public float VerMensalidade(){
            if(this.bolsista == true){
                return this.valorMensalidade*0.70f;
            } else{
                return valorMensalidade;
            }
        }
        
    }
}