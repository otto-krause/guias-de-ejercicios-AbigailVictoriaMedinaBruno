namespace E2
{
    public abstract class Mounstro
    {
        protected int puntosDeRespeto;
        protected string nombre;
        public string Nombre { get => nombre; }

        public Mounstro(string nombre){
            this.nombre = nombre;
            puntosDeRespeto = 0;
        }
        public abstract void hacerReir();
        public abstract void asustar();
        public bool esRespetable() { return puntosDeRespeto > 70 ;}
        public int losPuntosDeRespeto() { return puntosDeRespeto;}
    }
}