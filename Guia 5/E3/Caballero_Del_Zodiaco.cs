namespace E3
{
    public class Caballero_Del_Zodiaco
    {
        string nombre;
        string diosQueApoya;
        Armadura armadura;
        string signoDelZodiaco;

        public Caballero_Del_Zodiaco(string nombre, string diosQueApoya, Armadura armadura, string signoDelZodiaco)
        {
            this.nombre = nombre;
            this.diosQueApoya = diosQueApoya;
            this.armadura = armadura;
            this.signoDelZodiaco = signoDelZodiaco;
        }

        public string Nombre { get => nombre;}
        public string DiosQueApoya { get => diosQueApoya;}
        public Armadura Armadura { get => armadura;}
        public string SignoDelZodiaco { get => signoDelZodiaco;}
    }
}