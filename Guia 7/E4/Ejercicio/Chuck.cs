namespace Ejercicio
{
    public class Chuck : Pajaro
    {
        int velocidad;
        public Chuck(int ira, int velocidad) : base(ira)
        {
            this.velocidad = velocidad;
        }

        public override int fuerza(){
            if(velocidad>80){
                int kilometrosExtra = velocidad - 80;
                return 150 + (5*kilometrosExtra);
            }
            return 150;
        }
        public override void enojado(){
            velocidad*=2;
        }
        public override void terapiaGrupal()
        {
            ira=ira;
        }
    }
}