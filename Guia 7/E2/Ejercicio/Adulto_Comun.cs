using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Adulto_Comun : Adulto
    {
        public Adulto_Comun()
        {
        }

        public override int susto(int bolsaNiño, int capacidadDeSusto){   
            int tolerancia = listaDeIntentosDeSusto.Any(bolsaNiñoAux => bolsaNiñoAux > 15) ? 10 * listaDeIntentosDeSusto.Where(bolsaNiñoAux => bolsaNiñoAux > 15).Count() : 0; 
            listaDeIntentosDeSusto.Add(bolsaNiño);
            return tolerancia < capacidadDeSusto && tolerancia != 0 ? tolerancia / 2 : 0; 
        }
    }
}