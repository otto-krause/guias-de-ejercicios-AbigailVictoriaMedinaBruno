namespace Ejercicio
{
    public class Quirk
    {
        protected int tiempoDeUso;
        protected string nombre;
        protected bool tieneConsecuencias;
        public string Nombre { get => nombre;}

        protected Quirk(int tiempoDeUso){
            this.tiempoDeUso = tiempoDeUso;
        }

        public virtual double poder(){
            return tiempoDeUso * nombre.Length;
        }
        public virtual bool esPeligroso(){
            return (((poder()>1000) && (tiempoDeUso > 60)) || tieneConsecuencias);
        }
        public virtual void traspasa(){
        }
        public virtual void robar(Villano villanoAux){
        }
    }
}