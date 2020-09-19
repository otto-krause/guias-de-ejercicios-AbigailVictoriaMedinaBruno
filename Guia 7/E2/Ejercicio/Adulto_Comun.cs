using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Adulto_Comun : Adulto
    {
        List<int> listaDeIntentosDeSusto;
        public Adulto_Comun()
        {
            listaDeIntentosDeSusto = new List<int>{0};
        }

        public int susto(int bolsaNiño, int capacidadDeSusto){   
            
            int tolerancia = 10 * listaDeIntentosDeSusto.Where(bolsaNiñoAux => bolsaNiñoAux > 15).Count(); 
            listaDeIntentosDeSusto.Add(bolsaNiño);
            return tolerancia < capacidadDeSusto && tolerancia != 0 ? tolerancia / 2 : 0; 
        }
    }
}