namespace E4
{
    public class Pelicula
    {
        public string nombre,genero,director;
        public int año=0;
        public Pelicula(string nombre,string genero,string director,int año){
            this.nombre=nombre;
            this.genero=genero;
            this.director=director;
            this.año=año;
        }
    }
}