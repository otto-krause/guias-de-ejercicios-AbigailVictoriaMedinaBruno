using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class SueroMutante : Cosas
    {
        public SueroMutante()
        {
            this.Nombre = "Suero Mutante";
            this.NivelRequerido = 23;
        }
 
        public override List<Minion> premiar(List<Minion> listaMinions)
        {
            if(listaMinions.Where(i => i.CantBananas>100 && i.nivelDeConcentracion()>23).ToList().Count()>0){
                listaMinions.Where(i => i.CantBananas>100 && i.nivelDeConcentracion()>23).ToList().ForEach(i=>i.consumirSuero());
            }else{
                throw new Exception("Error .No hay minions que cumplan con los requisitos");
            }
            return listaMinions;
        }
    }
}