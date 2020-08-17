namespace Ejercicio
{
    public class Carpe : Varita
    {
        public Carpe(int potencia) : base(potencia)
        {
        }

        public override int tiempoParaPrepararLaReceta(Receta receta){
            return receta.Pasos / potencia;
        }

    }
}