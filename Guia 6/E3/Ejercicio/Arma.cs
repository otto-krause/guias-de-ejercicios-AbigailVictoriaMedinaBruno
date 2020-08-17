namespace Ejercicio
{
    public abstract class Arma
    {
        protected int potencia; 
        protected int desgaste;

        protected Arma(int potencia, int desgaste)
        {
            this.potencia = potencia;
            this.desgaste = desgaste;
        }

        public abstract int poder();
        public abstract void usar();
    }
}