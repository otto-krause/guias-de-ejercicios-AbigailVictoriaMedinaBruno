namespace Ejercicio
{
    public abstract class Varita
    {
        protected int potencia;

        protected Varita(int potencia)
        {
            this.potencia = potencia;
        }

        public abstract int tiempoParaPrepararLaReceta(Receta receta);
    }
}