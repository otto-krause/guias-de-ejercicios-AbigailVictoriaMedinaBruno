namespace Ejercicio
{
    public class PajaroComun : Pajaro
    {
        public PajaroComun(int ira) : base(ira)
        {
        }
        public override int fuerza(){
            return ira*2;
        }
        public override void enojado(){
            ira*=2;
        }
    }
}