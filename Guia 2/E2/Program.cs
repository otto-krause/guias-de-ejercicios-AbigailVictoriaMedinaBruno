using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string especialidad1;
            int contador=0;
            Clinica clinicas = new Clinica();
            Console.WriteLine("Ingrese la especialidad deseada y le mostraremos los medicos disponibles:");
            especialidad1=Console.ReadLine();
            
            foreach (Medico i in clinicas.medicos)
            {
                if(i.especialidad==especialidad1 && i.estaDisponible()){
                    contador++;
                    Console.WriteLine("El doctor "+ i.nombre +" "+ i.apellido +" esta disponible."); 
                }
            }
            if(contador==0){
                Console.WriteLine("Intente más tarde.");
            }
        }
    }
}
