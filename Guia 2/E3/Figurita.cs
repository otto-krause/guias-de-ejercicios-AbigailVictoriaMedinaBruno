
namespace E3
{
    public class Figurita
    {
        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        private string posicion;
        public string Posicion { get => posicion; set => posicion = value; }
        private string pais;
        public string Pais { get => pais; set => pais = value; }
        private int numeroDeFigurita=0;
        public int NumeroDeFigurita { get => numeroDeFigurita; set => numeroDeFigurita = value; }
        public Figurita(string nombre,string posicion,string pais,int numeroDeFigurita){
            this.nombre=nombre;
            this.posicion=posicion;
            this.pais=pais;
            this.numeroDeFigurita=numeroDeFigurita;
        }
    }
}