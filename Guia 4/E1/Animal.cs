namespace E1
{
    public abstract class Animal
    {
        protected int energia;

        public Animal(){
            energia = 0; 
        }
        public abstract void comer();
        public abstract void jugar();
        public void dormir() => energia += 1;
        public int mostrarEnergia(){ return energia; }//Agregué esto para poder saber la energía.
    }
}