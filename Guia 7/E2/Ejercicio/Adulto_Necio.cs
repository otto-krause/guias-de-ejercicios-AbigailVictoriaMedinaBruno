using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Adulto_Necio : Adulto
    {
        List<int> listaDeIntentosDeSusto; 
        public Adulto_Necio()
        {
            listaDeIntentosDeSusto = new List<int>{0};
        }

        public int susto(int bolsaNiño, int capacidadDeSusto){
            listaDeIntentosDeSusto.Add(bolsaNiño);
            return 0; 
        }
    }
}