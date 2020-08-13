using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Robin : Titan
    {
        List<Arma> arsenal;

        public Robin(List<Arma> arsenal,int tristeza)
        {
            this.arsenal = arsenal;
            this.tristeza = tristeza;
        }

        public override void comerPizza(){
            tristeza -= 1;
        }  
        public override void llorarPorRobocop(){
            tristeza += 6;
        }
        public override bool estaTriste(){
            return arsenal.Max(arma => arma.fuerza()) < 100 && tristeza > 25;
        }
        public override int poder(){
            Arma armaMasFuerte = arsenal.OrderByDescending(arma => arma.fuerza()).First();
            return armaMasFuerte.fuerza() - tristeza;
        }
    }
}