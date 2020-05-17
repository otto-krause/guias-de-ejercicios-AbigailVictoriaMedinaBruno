namespace E3
{
    public class LectoraDeCD:Componentes
    {
        //conectores
        private int precioDelComponente=0;
        private string conectores;

        public int PrecioDelComponente { get => precioDelComponente; }

        public LectoraDeCD(int precioDelComponente, string conectores)
        {
            this.precioDelComponente = precioDelComponente;
            this.conectores = conectores;
        }

        public int precio(){
            return precioDelComponente;
        }
        public bool esCompatible(Motherboard motherboard){
            return (conectores == motherboard.Conectores);
        }
    }
}