namespace E3
{
    public class PlacaDeVideo:Componentes
    {
        //conectores
        private int precioDelComponente=0;
        private string tipoDeZocalo;

        public PlacaDeVideo(int precioDelComponente, string tipoDeZocalo)
        {
            this.precioDelComponente = precioDelComponente;
            this.tipoDeZocalo = tipoDeZocalo;
        }

        public int PrecioDelComponente { get => precioDelComponente; }

        public int precio(){
            return precioDelComponente;
        }
        public bool esCompatible(Motherboard motherboard){
            return (tipoDeZocalo == motherboard.TipoDeZocaloVideo);
        }
    }
}