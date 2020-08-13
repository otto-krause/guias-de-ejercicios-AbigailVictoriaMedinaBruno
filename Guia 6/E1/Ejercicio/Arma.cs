namespace Ejercicio
{
    public class Arma
    {
        private int potencia;
        private int dureza;

        public Arma(int potencia, int dureza)
        {
            this.potencia = potencia;
            this.dureza = dureza;
        }

        public int fuerza(){
            return potencia + fibonacci();
        }
        private int fibonacci(){
            int a=0, b=0, c=1;
            for(int i = 2; i <= dureza ; i++ ){
                a = b;
                b = c;
                c = a + b;
            }    
            return dureza == 0 ? 0 : dureza == 1 ? 1 : c;
        }
    }
}