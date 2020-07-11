namespace E6
{
    public class Pelicula
    {
        private string nombre;
        public string Nombre { get => nombre;}
        private string genero;
        public string Genero { get => genero;}
        private string director;
        public string Director { get => director;}
        private int año=0;
        public int Año { get => año;}
        public Pelicula(string nombre,string genero,string director,int año){
            this.nombre=nombre;
            this.genero=genero;
            this.director=director;
            this.año=año;
        }
    }
}