namespace Ejercicio
{
    public class MilesMorales : Spiderman
    {
        int habilidadParaCantar;
        public MilesMorales(Traje traje, int fuerza, int habilidadParaCantar) : base(traje, fuerza)
        {
            this.habilidadParaCantar = habilidadParaCantar;
        }

        public override int poder(){
            return fuerza + habilidadParaCantar;
        }
    }
}