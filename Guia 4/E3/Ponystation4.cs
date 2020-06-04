namespace E3
{
    public class Ponystation4 : Consola
    {
        public Ponystation4(string nombre) : base(nombre)
        {
        }
        public override void agregarJuego(Juego juegoNuevo)
        {
            base.agregarJuego(juegoNuevo);
            puntos += 29;
        }
        public override void jugar(int horasDeJuego){
            puntos += 3*horasDeJuego;
        }
    }
}