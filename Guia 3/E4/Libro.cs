namespace E4
{
    public class Libro
    {
        private string titulo;
        private string autor;

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public string Titulo { get => titulo; }
        public string Autor { get => autor; }
    }
}