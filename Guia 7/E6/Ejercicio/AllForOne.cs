using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class AllForOne : Quirk
    {
        Villano miVillano;
        List<Quirk> quirksRobados;
        public AllForOne() : base(0){
            quirksRobados = new List<Quirk>();
            nombre = "All For One";
            tieneConsecuencias = false;
        }
        public override double poder(){
            return miVillano.damePoderSinAFO();
        }
        public override bool esPeligroso(){
            return quirksRobados.Any(quirk2 => quirk2.esPeligroso());
        }
        public override void robar(Villano villanoAux){
            miVillano = villanoAux;
        }
    }
}