namespace Ejercicio
{
    public class Ladron : Villano
    {
        /*La fuerza de todos los ladrones se calcula como la cantidad de maldades que cometieron
        Ladrones: le roban a los habitantes de la ciudad
De guante blanco: solo roban a los ricos de la ciudad
De guante marrón: le roban a la clase media
Robin hood: es un ladrón que le roba a los ricos para dárselo equitativamente a los de clase baja.
*/
        string tipo;
        int cantidadDeMaldades;
        string estado;

        public Ladron(string tipo)
        {
            this.tipo = tipo;
            this.cantidadDeMaldades = 0;
        }

        public int fuerza(){
            return cantidadDeMaldades;
        }
        public void cometerCrimen(CiudadGotica ciudad){
            ciudad.robos(tipo);
            cantidadDeMaldades++;
        }
        public int cuantosVillanosSon(){
            return 1;
        }
        public void peleaConBatman(string comoMeDejoBatman){
            estado = comoMeDejoBatman;
        }
        public bool estaProfugo(){
            return estado == "Profugo";
        }
    }
}