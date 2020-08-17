using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Zero
    {
        int poderDeZero;
        List<Arma> armasDeZero;

        public int PoderDeZero { get => poderDeZero; }

        public Zero(List<Arma> armasDeZero)
        {
            this.armasDeZero = armasDeZero;
            poderDeZero = laMasPolentosa().poder();
        }
        public bool loPuedeVencer(Maverick enemigoMaverick){
            return poderDeZero > enemigoMaverick.fuerza();
        }
        public bool losPuedeVencer(List<Maverick> enemigosMaverick){
            return enemigosMaverick.All(maverick => maverick.fuerza() < poderDeZero);
        }
        public Arma laMasPolentosa(){
            List<Arma> listaOrdenadaDeArmasDeZero = armasDeZero.OrderByDescending(armas => armas.poder()).ToList();
            poderDeZero = listaOrdenadaDeArmasDeZero.First().poder();
            return listaOrdenadaDeArmasDeZero.First();
        }
    }
}