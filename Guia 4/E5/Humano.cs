using System;
using System.Collections.Generic;
namespace E5
{
    public class Humano : SerPensante
    {
        public Humano() : base()
        {
        }

        public override void pensar(string conocimientoNuevo){
            List<string> listaReversa = listaDeConocimientos;
            listaReversa.Reverse(); 
            int i = 0;
            while(i<5 && listaDeConocimientos.Count > i){
                if(listaDeConocimientos[i] == conocimientoNuevo)
                    puntosDeInteligencia += 5;
                i++;
            }        
        }
    }
}