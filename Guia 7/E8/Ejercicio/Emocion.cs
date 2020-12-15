namespace Ejercicio
{
    public class Emocion
    {
        string nombre;
        bool esDominante;
        public string Nombre{get => nombre;}
        public bool EsDominante{get => esDominante;}
        public Emocion(string nombre, bool esDominante)
        {
            this.nombre = nombre;
            this.esDominante = esDominante;           
        }
        public void cambio(){
            esDominante = !esDominante;
        }
    }
}