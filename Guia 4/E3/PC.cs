namespace E3
{
    public class PC : Consola
    {
        public PC(string nombre) : base(nombre)
        {
        }
        public override void jugar(int horasDeJuego){
            puntos += 10*horasDeJuego;
        }
    }
}