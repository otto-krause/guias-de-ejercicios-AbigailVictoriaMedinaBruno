namespace E5
{
    public class Producto
    {
        string nombre;
        public string Nombre { get => nombre;}
        float precio=0;
        public float Precio { get => precio;}
        public Producto(string nombre, float precio){
            this.nombre=nombre;
            this.precio=precio;
        }

    }
}