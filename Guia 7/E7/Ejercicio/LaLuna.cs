using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class LaLuna : Cosas
    {
        Arma rayoCongelante;
        public LaLuna()
        {
            this.Nombre = "La Luna";
            this.NivelRequerido = 0;
            rayoCongelante = new Arma("Rayo Congelante",10);
        }
 
        public override List<Minion> premiar(List<Minion> listaMinions)
        {
            bool error=true;
            foreach (Minion item in listaMinions)
            {
                if(item.ListaDeArmas.Any(i => i.Nombre == "Rayo Encogedor"))
                {
                    item.ListaDeArmas.Add(rayoCongelante);
                    item.participarMaldad();
                    error=false;
                }
            }
            if(error)
                throw new Exception("Error .No hay minions que cumplan con los requisitos");
            return listaMinions;
        }
    }
}