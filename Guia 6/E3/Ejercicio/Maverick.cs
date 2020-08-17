namespace Ejercicio
{
    public class Maverick
    {
        Arma armaDeMaverick;
        int destreza;

        public Maverick(Arma armaDeMaverick, int destreza)
        {
            this.armaDeMaverick = armaDeMaverick;
            this.destreza = destreza;
        }

        public int fuerza(){
            return armaDeMaverick.poder() + destreza;
        }
        public bool esDebil(){
            return fuerza() < 200;
        }
    }
}