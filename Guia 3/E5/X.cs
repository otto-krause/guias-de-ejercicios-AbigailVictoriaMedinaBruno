namespace E5
{
    public class X
    {
        private Armadura armadura;
        private int dañoDeX_Buster = 0;

        public X(Armadura armadura)
        {
            this.armadura = armadura;
            this.dañoDeX_Buster = 10;
        }
        public void cambiarArmadura(Armadura armaduraNueva){
            armadura = armaduraNueva;
        }
        public int fuerza(){
            int suFuerza=0;
            suFuerza = dañoDeX_Buster + armadura.bonificacionDeDaño();
            return suFuerza;
        }
        public void entrenar(int minutosDeEntrenamiento){
            dañoDeX_Buster += 2 * minutosDeEntrenamiento;
            armadura.entrenamiento(minutosDeEntrenamiento);
        }
        
    }
}