using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class LegionDeLegiones : Legion
    {
        public LegionDeLegiones(List<Legion> listaDeLegiones) : base(listaDeLegiones)
        {
        }
        public override int capacidadDeAsustarTotal(){
            int aux = 0;
            listaDeLegiones.ForEach(legionAux => aux += legionAux.ListaDeNiños.Sum(niñoAux => niñoAux.capacidadDeAsustar()));
            return aux;
            //return legionDeNiños.Sum(niño => niño.capacidadDeAsustar());
        }
        public override int caramelosTotal(){
            int caramelosAux = 0;
            listaDeLegiones.ForEach(legionAux => caramelosAux += legionAux.ListaDeNiños.Sum(nene => nene.Bolsa));
            return caramelosAux;
            //return legionDeNiños.Sum(niño => niño.Bolsa);
        }
        public override void asustarAUnAdulto(Adulto adultoAux){
            //Niño lider = legionDeNiños.OrderBy(nene => nene.capacidadDeAsustar()).ToList().First();
            //lider.Bolsa += adultoAux.susto(caramelosTotal(),capacidadDeAsustar());
            Niño lider;
            int dulces = adultoAux.susto(caramelosTotal(),capacidadDeAsustarTotal());
            foreach (Legion legionAux in listaDeLegiones)
            {
                lider = legionAux.ListaDeNiños.OrderBy(nene => nene.capacidadDeAsustar()).ToList().First();
                lider.Bolsa += dulces / listaDeLegiones.Count(); 
            }
            
        }

    }
}