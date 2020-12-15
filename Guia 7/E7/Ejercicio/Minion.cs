using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Minion
    {
        int cantBananas;
        List<Arma> listaDeArmas;
        bool esVioleta;
        int participacionEnMaldades;
        public List<Arma> ListaDeArmas {get => listaDeArmas;set => listaDeArmas = value;}
        public int CantBananas {get => cantBananas;set => cantBananas = value;}
        public int ParticipacionEnMaldades{get => participacionEnMaldades;}
        public Minion(int cantBananas,Arma arma)
        {
            this.cantBananas = cantBananas;

            listaDeArmas = new List<Arma>{arma};
            esVioleta = false;
            participacionEnMaldades = 0;
        }
        public int nivelDeConcentracion(){
            if(!esVioleta)
                if(listaDeArmas.Count()>1)
                    return listaDeArmas.Max(arma => arma.Potencia) + cantBananas;
            return cantBananas;
        }
        public bool esPeligroso(){
            if(!esVioleta)
                    return listaDeArmas.Count()>2;
            return true;
                
        }
        public void consumirSuero(){
            if(!esVioleta)
                listaDeArmas.Clear();
            cantBananas-=1;
            esVioleta = !esVioleta;
        }
        public void agregarArma(Arma arma){
            listaDeArmas.Add(arma);
        }
        public void agregarBananas(int bananas){
            cantBananas+=bananas;
        }
        public void participarMaldad(){
            participacionEnMaldades++;
        }
    }
}