using System;
using System.Collections.Generic;
namespace E5
{
    public class SerPensante
    {
        protected List<string> listaDeConocimientos;
        protected List<string> listaDeIntereses;
        protected int puntosDeInteligencia;
        public SerPensante(){
            listaDeConocimientos = new List<string>();
            listaDeIntereses = new List<string>();
            puntosDeInteligencia = 0;
        }
        public virtual void estudiar(string conocimientoNuevo){
            listaDeConocimientos.Add(conocimientoNuevo);
            if(listaDeIntereses.Contains(conocimientoNuevo))
                puntosDeInteligencia++;
        }
        public virtual void pensar(string conocimientoNuevo){
            puntosDeInteligencia += listaDeConocimientos.Count;
        }
        public int mostrarPuntosDeInteligencia(){
            return puntosDeInteligencia;
        }
    }
}