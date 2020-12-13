namespace Ejercicio
{
    public abstract class Pajaro
    {
        protected int ira;

        protected Pajaro(int ira)
        {
            this.ira = ira;
        }

        public abstract int fuerza();
        public abstract void enojado();
        public virtual void terapiaGrupal(){
            ira-=5;
        }
    }
}