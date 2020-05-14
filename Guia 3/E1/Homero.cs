namespace E1
{
    public class Homero:Empleado
    {
        private int donas;

        public Homero(int donas)
        {
            this.donas = donas;
        }

        public bool estaDistraido(){
            return donas<2;
        }
        public void comer(){
            donas--;
        }
        public void comprar(){
            donas+=12;
        }
    }
}