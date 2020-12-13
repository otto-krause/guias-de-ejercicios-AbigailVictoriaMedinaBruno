namespace Ejercicio
{
    public class Bomb : Pajaro
    {
        int topeMaximoDeFuerza;
        public Bomb(int ira) : base(ira)
        {
            topeMaximoDeFuerza=9000;
        }
        public override int fuerza(){
            if(ira*2>topeMaximoDeFuerza)
                return topeMaximoDeFuerza;
            return ira*2;
        }
        public override void enojado(){
            ira*=2;
        }
    }
}