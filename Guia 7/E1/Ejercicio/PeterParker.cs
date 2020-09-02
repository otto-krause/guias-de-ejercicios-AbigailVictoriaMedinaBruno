namespace Ejercicio
{
    public class PeterParker : Spiderman
    {
        public PeterParker(Traje traje, int fuerza) : base(traje, fuerza)
        {
        }
        public override int poder(){
            return fuerza + traje.Resistencia;
        }
        
    }
}