using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Tecnologia
    {
        string nombre;
        int potencia;
        int cantidadDeUsos;

        public Tecnologia(string nombre, int potencia, int cantidadDeUsos)
        {
            this.nombre = nombre;
            this.potencia = potencia;
            this.cantidadDeUsos = cantidadDeUsos;
        }

        public string Nombre { get => nombre;}
        public int Potencia { get => potencia;}
        public int CantidadDeUsos { get => cantidadDeUsos;}

        public int poderDeHerramienta(){
            return potencia / cantidadDeUsos;
        }
        public void combatiendoCrimen(){
            cantidadDeUsos++;
        }
    }
}