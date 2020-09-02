namespace Ejercicio
{
    public class SpidermanNoir : Spiderman
    {
        PeterParker peter;
        public SpidermanNoir(Traje traje, int fuerza, PeterParker peter) : base(traje, fuerza)
        {
            this.peter = peter;
        }
        public override int poder(){
            return peter.poder() + traje.ListaDeArmas.Count;
        }

        
    }
}