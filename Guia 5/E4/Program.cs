using System;
using System.Collections.Generic;
using System.Linq;
namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string especialidad1 = "";
            Clinica clinicas = new Clinica();

            while(especialidad1 != "salir"){
                Console.WriteLine("\nIngrese la especialidad deseada(si desea salir ingrese *salir*):");
                especialidad1 = Console.ReadLine();
                if(especialidad1 != "salir"){
                    Medico medico1 = clinicas.buscarMedico(especialidad1);
                    if(medico1 != null)
                        Console.WriteLine("El doctor "+ medico1.Nombre +" "+ medico1.Apellido +" esta disponible, se le asigno un turno.");
                    else
                        Console.WriteLine("Intente de nuevo más tarde.");
                }
            }
        }
    }
}
