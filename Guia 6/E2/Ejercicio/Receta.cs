using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Receta
    {
        private int pasos;
        private List<int> caloriasDeIngredientes;
        public int Pasos { get => pasos;}
        public List<int> CaloriasDeIngredientes { get => caloriasDeIngredientes; }      

        public Receta(int pasos, List<int> caloriasDeIngredientes)
        {
            this.pasos = pasos;
            this.caloriasDeIngredientes = caloriasDeIngredientes;
        }
        public bool siEsDeGordo(){
            return caloriasDeIngredientes.Sum()>2000;
        }
        public bool esRapida(){
            return (caloriasDeIngredientes.Count()/pasos) > 1;
        }
    }
}