using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Kingpin
    {
        int puntosDeVida;

        public Kingpin()
        {
            this.puntosDeVida = 800;
        }
        public bool fueVencido(){
            return puntosDeVida < 0;
        }
        public void fueAtacado(int poderDeSpiderman){
            puntosDeVida -= poderDeSpiderman;
        }
    }
}