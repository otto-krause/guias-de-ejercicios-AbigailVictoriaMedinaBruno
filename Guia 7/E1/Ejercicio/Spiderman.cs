using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public abstract class Spiderman
    {
        protected Traje traje;
        protected int fuerza;

        public Traje Traje { get => traje; }
        public int Fuerza { get => fuerza; }

        protected Spiderman(Traje traje, int fuerza)
        {
            this.traje = traje;
            this.fuerza = fuerza;
        }
        public abstract int poder();
        public void atacar(Kingpin kingpinAux){
            kingpinAux.fueAtacado(poder());
        }
        
    }
}