namespace E2
{
    public class Amigable : Mounstro
    {
        public Amigable(string nombre) : base(nombre)
        {
        }
        public override void hacerReir() => puntosDeRespeto += 1;
        public override void asustar() => puntosDeRespeto += 7;
    }
}