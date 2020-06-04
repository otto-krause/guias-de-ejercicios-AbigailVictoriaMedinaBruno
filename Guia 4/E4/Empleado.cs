namespace E4
{
    public class Empleado
    {
        protected int cajaBancaria;

        public Empleado()
        {
            cajaBancaria = 0;
        }

        public void extraer(int cantidadExtracción){
            cajaBancaria -= cantidadExtracción;
        }
        public virtual void depositar(int numero){
            cajaBancaria += 35000;
        }
        public int mostrarCajaBancaria(){
            return cajaBancaria;
        }
    }
}