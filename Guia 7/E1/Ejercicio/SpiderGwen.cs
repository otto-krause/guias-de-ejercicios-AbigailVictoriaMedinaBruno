using System;
namespace Ejercicio
{
    public class SpiderGwen : Spiderman
    {
        int glamour;

        public int Glamour { get => glamour; }

        public SpiderGwen(Traje traje, int fuerza, int glamour) : base(traje, fuerza)
        {
            this.glamour = glamour;
            if(glamour < 1 || glamour > 10){
                throw new Exception("El glamour ingresado esta fuera de rango");
            }
        }
        public override int poder(){
            return fuerza + glamour;
        }
        
    }
}