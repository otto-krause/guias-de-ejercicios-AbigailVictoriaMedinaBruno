using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Abuelo : Adulto
    {
        public Abuelo()
        {
        }

        public override int susto(int bolsaNiño,int capacidadDeSusto){
            int tolerancia = 10 * listaDeIntentosDeSusto.Where(niñoAux => niñoAux > 15).ToList().Count(); 
            listaDeIntentosDeSusto.Add(bolsaNiño);
            return tolerancia / 4; 
        }
    }
}