namespace Ejercicio
{
    public class CerditoArmado : Obstaculo
    {
        int resistenciaDeproteccion;

        public CerditoArmado(int resistenciaDeproteccion) : base()
        {
            this.resistenciaDeproteccion = resistenciaDeproteccion;
        }
        public override int resistencia(){
            return 10*resistenciaDeproteccion;
        }
    }
}