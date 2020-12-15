using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Cosas
    {
        protected string nombre;
        protected int nivelRequerido;
        public string Nombre { get => nombre; set => nombre = value; }
        public int NivelRequerido { get => nivelRequerido; set => nivelRequerido = value; }

        public virtual List<Minion> premiar(List<Minion> listaMinions)
        {
            return listaMinions;    
        }
    }
}