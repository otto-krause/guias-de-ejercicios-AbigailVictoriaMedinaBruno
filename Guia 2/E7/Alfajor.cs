namespace E7
{
    public class Alfajor
    {
        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        private string empresa;
        public string Empresa { get => empresa; set => empresa = value; }
        private int precio=0;
        public int Precio { get => precio; set => precio = value; }

        public Alfajor(string nombre, string empresa, int precio)
        {
            this.nombre = nombre;
            this.empresa = empresa;
            this.precio = precio;
        }
    }
}