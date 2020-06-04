namespace E3
{
    public class Ponystation4_pro_SaladaEdition : Ponystation4
    {
        public Ponystation4_pro_SaladaEdition(string nombre) : base(nombre)
        {
        }
        public override void agregarJuego(Juego juegoNuevo)
        {
            listaDeJuegos.Remove(listaDeJuegos[0]);
            base.agregarJuego(juegoNuevo);
        }
        public override int revisarPuntaje() {return base.revisarPuntaje()/2;}
    }
}