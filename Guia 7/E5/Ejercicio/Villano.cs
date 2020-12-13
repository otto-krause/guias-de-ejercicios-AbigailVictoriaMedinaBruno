namespace Ejercicio
{
    public class Villano 
    {
        bool roboEnOnce;
        bool noTrabajoNunca;
        bool leGustaLaPizzaConPiña;
        Quirk quirk;

        public Villano(bool roboEnOnce, bool trabajo, bool leGustaLaPizzaConPiña, Quirk quirk)
        {
            this.roboEnOnce = roboEnOnce;
            this.noTrabajoNunca= noTrabajoNunca;
            this.leGustaLaPizzaConPiña = leGustaLaPizzaConPiña;
            this.quirk = quirk;
        }
        public bool esMuyMalo(){
            return roboEnOnce && noTrabajoNunca && leGustaLaPizzaConPiña;
        }
        public bool algunaVezFueBueno(){
            return quirk.esPeligroso() && !noTrabajoNunca;
        }
        public int poderDeQuirk(){
            return quirk.poder();
        }
    }
}