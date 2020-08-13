using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Raven : Titan
    {
        int felicidad;
        List<string> pensamientos;

        public Raven(List<string> pensamientos,int felicidad)
        {
            this.pensamientos = pensamientos;
            this.felicidad = felicidad;
        }
        private int cuantosPensamientosNegativos(){
            return pensamientos
            .Where(pensamiento => pensamiento.Contains("Papi") ||
            pensamiento.Contains("perrito") ||
            pensamiento.Contains("Robocop") || 
            pensamiento.Contains("Pipo") || 
            pensamiento.Contains("MANTECA")).ToList().Count();

        }

        public override void comerPizza(){
            felicidad += 2;
        }  
        public override void llorarPorRobocop(){
            pensamientos.RemoveAt(0); 
        }
        public override bool estaTriste(){
            return cuantosPensamientosNegativos() >= 5 && felicidad == 10;
        }
        public override int poder(){
            return cuantosPensamientosNegativos();
        }
    }
}