using System;
using System.Linq;
using System.Collections.Generic;
namespace E5
{
    public class Persona
    {
        List<string> conocimientos;
        public List<string> Conocimientos { get => conocimientos;}
        public Persona(List<string> conocimientos)
        {
            this.conocimientos = conocimientos;
        }
        public List<string> ultimos5Conocimientos(){
            List<string> conocimientosAux1 = conocimientos;
            conocimientosAux1.Reverse();
            if(conocimientosAux1.Count >= 5)
               conocimientosAux1 = conocimientosAux1.GetRange(0,5);
            return conocimientosAux1;
        }
        public List<string> primeros4Conocimientos(){
            
            List<string> conocimientosAux2 = conocimientos;
            conocimientosAux2.Reverse();
            if(conocimientosAux2.Count >= 4)
                conocimientosAux2 = conocimientosAux2.GetRange(0,4);
            return conocimientosAux2.OrderBy(j => j).ToList();
        }
        public int cuantosTienenCion(){
            return conocimientos.Where(i => i.Contains("ción")).ToList().Count();
        }
        
    }
}