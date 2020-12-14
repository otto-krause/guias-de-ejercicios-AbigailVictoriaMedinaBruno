using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Villano 
    {
        bool roboEnOnce;
        bool noTrabajoNunca;
        bool leGustaLaPizzaConPiña;
        public List<Quirk> listaDeQuirk;

        public Villano(bool roboEnOnce, bool trabajo, bool leGustaLaPizzaConPiña, List<Quirk> listaDeQuirk)
        {
            this.roboEnOnce = roboEnOnce;
            this.noTrabajoNunca = noTrabajoNunca;
            this.leGustaLaPizzaConPiña = leGustaLaPizzaConPiña;
            this.listaDeQuirk = listaDeQuirk;
        }
        public bool esMuyMalo(){
            return roboEnOnce && noTrabajoNunca && leGustaLaPizzaConPiña;
        }
        public bool algunaVezFueBueno(){
            return listaDeQuirk.Any(i => i.esPeligroso()) && !noTrabajoNunca;
        }
        public double poderDeQuirk(){
            return listaDeQuirk.Sum(j => j.poder());
        }
        public void traspasarQuirk(Villano villano){
            Quirk aux;
            if(listaDeQuirk.Any(quirk => quirk.Nombre=="One For All")){
                aux = listaDeQuirk.Where(quirk => quirk.Nombre=="One For All").ToList().First();
                //listaDeQuirk.Where(quirk => quirk.Nombre=="One For All").ToList().ForEach(i => i.traspasa());
                aux.traspasa();
                villano.listaDeQuirk.Add(aux);
                listaDeQuirk.Remove(aux);
            }
        }
        public void robarQuirk(Villano villano){
            Quirk aux;
            if(listaDeQuirk.Any(quirk => quirk.Nombre=="All For One")){
                if(villano.listaDeQuirk.Count()>=1){
                    villano.listaDeQuirk.ForEach(quirk => listaDeQuirk.Add(quirk));
                    villano.listaDeQuirk.Clear();
                }
                aux = listaDeQuirk.Where(quirk => quirk.Nombre=="All For One").ToList().First();
                aux.robar(this);
            }
        }
        public double damePoderSinAFO(){
            double total = 0;
            foreach (Quirk i in listaDeQuirk)
            {
                if(i.Nombre != "All For One")
                    total += i.poder();
            }
            return total;
        }
        
    }
}