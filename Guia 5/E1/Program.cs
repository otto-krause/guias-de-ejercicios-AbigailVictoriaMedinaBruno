using System;
using System.Linq;
using System.Collections.Generic;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaDePersonas = new List<Persona>{new Persona("Pablo","Martinez",21),
            new Persona("Juan","Pérez",26),
            new Persona("Nicolas","Kazaki",15),
            new Persona("Juan","Rechetti",42)};
            
            Console.WriteLine("\nPersonas mayores de edad:");
            listaDePersonas.Where(Persona => Persona.Edad >= 18)
            .ToList()
            .ForEach(Persona => Console.WriteLine(Persona.Nombre +" "+ Persona.Apellido +" / Edad: "+ Persona.Edad));
            
            Console.WriteLine("\nPersonas de nombre Juan:");
            listaDePersonas.Where(Persona => Persona.Nombre == "Juan")
            .ToList()
            .ForEach(Persona => Console.WriteLine(Persona.Nombre +" "+ Persona.Apellido +" / Edad: "+ Persona.Edad));
            
            Console.WriteLine("Hay "+listaDePersonas.Count(Persona => Persona.Apellido == "Pérez")+" persona/s con apellido Perez");
        }
    }
}
