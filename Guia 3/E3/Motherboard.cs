namespace E3
{
    public class Motherboard
    {
        private string nombre;
        private string tipoDeZocaloVideo;
        private int frecuenciaMIN=0;
        private int frecuenciaMAX=0;
        private string conectores;

        public Motherboard(string nombre, string tipoDeZocaloVideo, int frecuenciaMIN, int frecuenciaMAX, string conectores)
        {
            this.nombre = nombre;
            this.tipoDeZocaloVideo = tipoDeZocaloVideo;
            this.frecuenciaMIN = frecuenciaMIN;
            this.frecuenciaMAX = frecuenciaMAX;
            this.conectores = conectores;
        }

        public string Nombre { get => nombre;}
        public int FrecuenciaMIN { get => frecuenciaMIN;}
        public int FrecuenciaMAX { get => frecuenciaMAX;}
        public string Conectores { get => conectores;}
        public string TipoDeZocaloVideo { get => tipoDeZocaloVideo; }
    }
}