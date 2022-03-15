namespace AulaPOOCelular
{
    public class Celular
    {
        public string color;
        public string model;
        public double size;
        public bool isOn;

        public string TurnOn(){
            if(isOn){
                return "Seu celular já está ligado";
            } else{
                isOn = true;
                return "Celular ligado";
            }
        }

        public string TurnOff(){
            if(!isOn){
                return "Seu celular já está desligado";
            } else{
                isOn = false;
                return "Celular desligado";
            }
        }

        public string SendMessage(){
            if(isOn){
                return "Enviando mensagem...";
            } else{
                return "Celular desligado. Ligue-o para enviar uma mensagem";
            }
        }
        public string Call(){
            if(isOn){
                return "Ligando para...";
            } else{
                return "Celular desligado. Ligue-o para ligar para alguém";
            }
        }
    }
}