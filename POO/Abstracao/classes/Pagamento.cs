using System;

namespace Abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        public DateTime Data{
            get{return data;}
        }

        protected float valor;

        public string Cancelar(){
            return "";
        }

        public abstract string Desconto(int valor);
    }
}