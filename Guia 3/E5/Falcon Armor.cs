namespace E5
{
    public class Falcon_Armor : Armadura
    {
        private int potencia=0;
        private int resistencia=0;

        public Falcon_Armor ()
        {
            this.potencia = 25;
            this.resistencia = 10;
        }
        public int bonificacionDeDaño(){
            return (potencia+resistencia)/2;
        }
        public void entrenamiento(int minutosDeEntrenamiento){
            if(potencia == 0)
                resistencia -= minutosDeEntrenamiento;
            potencia += 10;
            
        }
    }
}