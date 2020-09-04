using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Adulto_Necio : Adulto
    {
        public Adulto_Necio()
        {
        }

        public override int susto(int bolsaNiño, int capacidadDeSusto){
            listaDeIntentosDeSusto.Add(bolsaNiño);
            return 0; 
        }
    }
}