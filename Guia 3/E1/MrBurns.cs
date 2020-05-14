namespace E1
{
    public class MrBurns
    {
        private bool tieneRiquezas;

        public MrBurns()
        {
            this.tieneRiquezas = true;
        }

        public bool esMillonario(){
            return tieneRiquezas;
        }

        public void despojarDeSusRiquezas(){
            tieneRiquezas = false;
        }
    }
}