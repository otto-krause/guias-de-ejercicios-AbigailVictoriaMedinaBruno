namespace Ejercicio
{
    public class SpiderGwen : Spiderman
    {
        int glamour;

        public int Glamour { get => glamour; }

        public SpiderGwen(Traje traje, int fuerza, int glamour) : base(traje, fuerza)
        {
            this.glamour = glamour;
        }
        public override int poder(){
            return fuerza + glamour;
        }
        
    }
}