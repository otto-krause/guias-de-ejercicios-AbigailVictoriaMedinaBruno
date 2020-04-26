using System;
using System.Collections.Generic;
namespace E3
{
    public class Album
    {
        public int contador=0,delanteros=0,mediocampistas=0;
        public List<Figurita> figuritas = new List<Figurita>();
        public bool copia(Figurita guardadas){
            contador=0;
            foreach (Figurita i in figuritas){
                if(guardadas.numeroDeFigurita == i.numeroDeFigurita)
                    contador=1;
            }
            if(contador == 0)
                figuritas.Add(guardadas);

            return contador == 0;
        }
        public int cuantosDelanteros(){
            foreach (Figurita i in figuritas){
                if(i.posicion == "Delantero")
                    delanteros++;
            }
            return delanteros;
        }
        public int cuantosMediocampistas(){
            for (int i = 0; i < figuritas.Count; i++){
                if(figuritas[i].posicion == "Mediocampista")
                    mediocampistas++;
            }
            return mediocampistas;
        }
        public bool estaCompleto(){
            return (figuritas.Count == 352);
        }
    }
}