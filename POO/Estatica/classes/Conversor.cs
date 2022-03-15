namespace Estatica.classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5;
        private static float cotacaoEuro = 5.53f;

        public static float RealParaDolar(float valorReal){
            return valorReal / cotacaoDolar;
        }

        public static float RealParaEuro(float valorReal){
            return valorReal / cotacaoEuro;
        }

        public static float DolarParaReal(float valorDolar){
            return valorDolar * cotacaoDolar;
        }

        public static float EuroParaReal(float valorEuro){
            return valorEuro * cotacaoEuro;
        }
        
        
    }
}