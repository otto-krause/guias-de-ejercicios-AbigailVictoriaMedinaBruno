using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Villano
    {
        Arma rayoCongelante;
        List<Minion> listaDeMinions;
        public List<Minion> ListaDeMinions{get => listaDeMinions;}
        public Villano()
        {
            listaDeMinions = new List<Minion>();
            rayoCongelante = new Arma("Rayo Congelante",10);
        }
        public void obtenerMinion(){
            listaDeMinions.Add(new Minion(5,rayoCongelante));
        }
        public void otorgarArma(Arma arma){
            var rnd = new Random();
            listaDeMinions[rnd.Next(0,listaDeMinions.Count())].agregarArma(arma);
        }
        public void alimentar(int bananasAdicionales){
            var rnd = new Random();
            listaDeMinions[rnd.Next(0,listaDeMinions.Count())].agregarBananas(bananasAdicionales);
        }
        public void congelarCiudad(Ciudad ciudadDelVillano){
            List<Minion> listaAux = listaDeMinions.Where(minion => minion.ListaDeArmas.Any(arma => arma.Nombre == "Rayo Congelante")).ToList();
            if(!(listaAux.Count()>=1))
                throw new Exception("Error .No hay minions que cumplan con los requisitos");
            else
            {
                if(listaAux.Sum(minion => minion.nivelDeConcentracion())>=500)
                    ciudadDelVillano.ciudadFria();
                    foreach(Minion minionAux in listaAux){
                        minionAux.agregarBananas(10);
                        minionAux.participarMaldad();
                    }
            }
        }
        public void robarCiudad(Cosas cosa){ 
            listaDeMinions = cosa.premiar(listaDeMinions);
        }
    }
}