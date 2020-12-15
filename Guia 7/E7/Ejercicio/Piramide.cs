using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Piramide : Cosas
    {
        private int altura;
       
        public Piramide(int altura)
        {
            this.Altura = altura;
            this.Nombre = "Piramide";
            this.NivelRequerido = this.Altura / 2;
        }

        public int Altura { get => altura; set => altura = value; }
 
        public override List<Minion> premiar(List<Minion> listaMinions)
        {
            bool error = true;
            foreach (Minion item in listaMinions)
            {
                if(item.nivelDeConcentracion() >= nivelRequerido){
                    item.agregarBananas(10);
                    error = false;
                }
            }
            if(error)
                throw new Exception("Error .No hay minions que cumplan con los requisitos");
            return listaMinions;
        }
    }
}