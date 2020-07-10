using System;
using System.Collections.Generic;
namespace E1
{
    public class Persona
    {
        string nombre;
        string apellido;
        int edad;
        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public int Edad { get => edad;}
        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        
    }
}