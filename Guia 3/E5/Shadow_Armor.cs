namespace E5
{
    public class Shadow_Armor : Armadura
    {
        private int nivelDeDesgaste = 0;

        public Shadow_Armor()
        {
            this.nivelDeDesgaste = 0;
        }

        public int bonificacionDeDaño(){
            if(nivelDeDesgaste == 0)
                return 0;
            else
                return 80/nivelDeDesgaste;
        }
        public void entrenamiento(int minutosDeEntrenamiento){
            nivelDeDesgaste += 2*minutosDeEntrenamiento;
        }
    }
}