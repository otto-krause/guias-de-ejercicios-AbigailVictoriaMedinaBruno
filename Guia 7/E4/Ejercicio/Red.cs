namespace Ejercicio
{
    public class Red : Pajaro
    {
        int cantidadVecesEnojado;

        public int CantidadVecesEnojado { get => cantidadVecesEnojado;}

        public Red(int ira) : base(ira)
        {
            cantidadVecesEnojado = 0;
        }

        public override int fuerza(){
            return ira*10*cantidadVecesEnojado;
        }
        public override void enojado(){
            cantidadVecesEnojado++;
            ira*=2;
        }
    }
}