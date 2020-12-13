namespace Ejercicio
{
    public class Obstaculo
    {
        bool derribado;

        public Obstaculo()
        {
            derribado = false;
        }

        public bool Derribado { get => derribado;}
        public virtual int resistencia(){
            return 0;
        }

        public void ataque(Pajaro pajaro){
            if(pajaro.fuerza()>resistencia()){
                derribado=true;
            }
        }
    }
}