using System;
using System.Collections.Generic;
namespace E3
{
    public class PC
    {
        private List<Componentes> listaDeComponentes;
        private int total=0;
        private bool sePuede=true;
        private Motherboard motherboard;
        public PC(){
              listaDeComponentes = new List<Componentes>();
              motherboard = new Motherboard("Z490 AORUS XTREME WATERFORCE (rev. 1.0)","PCI-X",2133,2666,"SATA 6GB");
        }
        public void añadir(Componentes componenteAñadido){
            listaDeComponentes.Add(componenteAñadido);
        }
        public int PrecioTotal(){
            foreach(Componentes aux in listaDeComponentes){
                total+=aux.precio();
            }
            return total;
        }
        public bool sePuedeArmar(){
            foreach(Componentes aux in listaDeComponentes){
                if(sePuede==true)
                    sePuede = aux.esCompatible(motherboard);
            }
            return sePuede;
        }
    }
}