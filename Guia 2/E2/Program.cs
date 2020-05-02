using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string especialidad1="hi";
            Clinica clinicas = new Clinica();

            while(especialidad1 != "salir"){
                Console.WriteLine("Ingrese la especialidad deseada(si desea salir ingrese *salir*):");
                especialidad1=Console.ReadLine();
                Medico medico1 = clinicas.buscarMedico(especialidad1);
                if(medico1 != null)
                    Console.WriteLine("El doctor "+ medico1.Nombre +" "+ medico1.Apellido +" esta disponible, se le asigno un turno.");
                else
                    Console.WriteLine("Intente de nuevo más tarde.");
            }
        }
    }
}
