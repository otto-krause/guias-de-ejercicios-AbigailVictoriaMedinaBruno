using System;
using System.Collections.Generic;
namespace E2
{
    public class Empresa
    {
        List<Mounstro> listaDeMounstros;
        Mounstro Mike;
        Mounstro Sullivan;
        public Empresa(){
            listaDeMounstros = new List<Mounstro>();
            Mike = new Amigable("Mike");
            Sullivan = new Peligroso("Sullivan");
            listaDeMounstros.Add(Mike);
            listaDeMounstros.Add(Sullivan);

        }
        public void nocheDeSustos(){
            foreach(Mounstro monsterAux in listaDeMounstros){
                monsterAux.asustar();
            }
        }
        public void nocheDeRisas(){
            foreach(Mounstro monsterAux in listaDeMounstros){
                monsterAux.hacerReir();
            }
        }
        public List<Mounstro> listaDeMounstrosRespetables(){
            List<Mounstro> listaAux = new List<Mounstro>();
            foreach(Mounstro monsterAux in listaDeMounstros){
                if(monsterAux.esRespetable())
                    listaAux.Add(monsterAux);
            }
            return listaAux;
        }
        public int energiaGenerada(){
            int contadorDeEnergia = 0;
            foreach(Mounstro monsterAux in listaDeMounstros){
                contadorDeEnergia += monsterAux.losPuntosDeRespeto();
            }
            return contadorDeEnergia;
        }

    }
}