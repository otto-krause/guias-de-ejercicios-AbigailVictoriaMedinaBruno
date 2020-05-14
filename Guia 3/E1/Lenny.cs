namespace E1
{
    public class Lenny:Empleado
    {
        private int cervezasTomadas;

        public Lenny()
        {
            this.cervezasTomadas = 0;
        }

        public bool estaDistraido(){
            return cervezasTomadas > 3;
        }

        public void tomarCerverza(){
            cervezasTomadas++;
        }
    }
}