namespace E2
{
    public class Peligroso : Mounstro
    {
        public Peligroso(string nombre) : base(nombre)
        {
        }
        public override void hacerReir(){ 
            if(puntosDeRespeto>=2)
                puntosDeRespeto -= 2;
            else
                puntosDeRespeto = 0;
        }
        public override void asustar() => puntosDeRespeto += 5;
    }
}