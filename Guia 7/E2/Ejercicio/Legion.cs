using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Legion : Malevolo
    {
        List<Malevolo> listaDeMalevolos;
        int bolsaDeLegion;
        
        public Legion(List<Malevolo> listaDeMalevolos)
        {
            this.listaDeMalevolos = listaDeMalevolos;
        }

        public List<Malevolo> ListaDeMalevolos { get => listaDeMalevolos;}
        public int BolsaDeLegion { get => bolsaDeLegion; }

        public int cantidadDeCaramelos(int masCaramelos){
            bolsaDeLegion =+ masCaramelos;
            int bolsa = listaDeMalevolos.Sum(malevolo => malevolo.cantidadDeCaramelos(0));
            return bolsa + bolsaDeLegion;
        }
        public int capacidadDeAsustar(){
            return listaDeMalevolos.Sum(malevolo => malevolo.capacidadDeAsustar());
        }
        
        public void asustarAUnAdulto(Adulto adultoAux){
            Malevolo lider = listaDeMalevolos.OrderBy(malevolo => malevolo.capacidadDeAsustar()).ToList().First();
            //if(lider.listaDeMalevolos.)
            lider.cantidadDeCaramelos(adultoAux.susto(cantidadDeCaramelos(0),capacidadDeAsustar()));
        }
        


    }
}