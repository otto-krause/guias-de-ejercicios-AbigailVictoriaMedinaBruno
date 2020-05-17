namespace E3
{
    public class MemoriaRam:Componentes
    {
        private int precioDelComponente=0;
        private int frecuencia=0;

        public int PrecioDelComponente { get => precioDelComponente; }

        public MemoriaRam(int precioDelComponente, int frecuencia)
        {
            this.precioDelComponente = precioDelComponente;
            this.frecuencia = frecuencia;
        }

        public int precio(){
            return precioDelComponente;
        }
        public bool esCompatible(Motherboard motherboard){
            return (frecuencia>=motherboard.FrecuenciaMIN) && (frecuencia<=motherboard.FrecuenciaMAX);
        }
    }
}