namespace Ejercicio
{
    public class Pared : Obstaculo
    {
        int anchoDePared;
        string tipo;
        public Pared(int anchoDePared, string tipo) : base()
        {
            this.anchoDePared = anchoDePared;
            this.tipo = tipo;
        }
        public override int resistencia(){
            switch(tipo){
                case "vidrio": return 10*anchoDePared;
                case "madera": return 25*anchoDePared;
                case "piedra": return 50*anchoDePared;
            }
            return 0;
        }
    }
}