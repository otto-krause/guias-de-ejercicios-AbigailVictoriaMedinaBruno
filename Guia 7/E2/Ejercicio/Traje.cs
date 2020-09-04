namespace Ejercicio
{
    public class Traje
    {
        string nombre;
        string queEs;

        public Traje(string nombre, string queEs)
        {
            this.nombre = nombre;
            this.queEs = queEs;
        }

        public int susto(){
            return queEs == "Tierno" ? 2 : queEs == "Terrorifico" ? 5 : 0;
        }
    }
}