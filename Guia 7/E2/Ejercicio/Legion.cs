using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Legion
    {
        /*Los niños son más efectivos si asustan en grupos, que son llamados “legiones de terror”.
         De estas sabemos que:
● La capacidad de asustar de una legión es equivalente a la sumatoria las capacidades de sus miembros
● La cantidad de caramelos en posesión de la legión es equivalente a la sumatoria de caramelos en
 posesión de sus miembros
● Al igual que los niños, cuando intentan asustar, reciben caramelos. 
Sin embargo, los caramelos van a las arcas del líder de la legión.
 El líder es el miembro con mayor capacidad de asustar.
1.   Dado un conjunto de niños, crear una legión. Toda legión debe tener al menos dos niños, 
por lo que la creación debe fallar si no se cumple esta restricción.
2.  Hacer que una legión intente asustar a una persona, obteniendo los caramelos, si aplica.
3.   Nos informan que los niños han aprendido a formar legiones de legiones, es decir,
 legiones donde sus miembros pueden ser niños u otras legiones. 
 Si es necesario hacer algún cambio para soportar este requerimiento, realizarlo.
 De lo contrario, explicar porqué es posible.
*/
        List<Niño> listaDeNiños;
        public List<Niño> ListaDeNiños { get => listaDeNiños; }

        protected List<Legion> listaDeLegiones;

        public Legion(List<Niño> listaDeNiños)
        {
            this.listaDeNiños = listaDeNiños;
        }

        protected Legion(List<Legion> listaDeLegiones)
        {
            this.listaDeLegiones = listaDeLegiones;
        }

        public virtual int capacidadDeAsustarTotal(){
            return listaDeNiños.Sum(niño => niño.capacidadDeAsustar());
        }
        public virtual int caramelosTotal(){
            return listaDeNiños.Sum(niño => niño.Bolsa);
        }
        public virtual void asustarAUnAdulto(Adulto adultoAux){
            Niño lider = listaDeNiños.OrderBy(nene => nene.capacidadDeAsustar()).ToList().First();
            lider.Bolsa += adultoAux.susto(caramelosTotal(),capacidadDeAsustarTotal());
        }
        


    }
}