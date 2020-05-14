using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int PresupuestoDelProyecto=0;
            int horasDeRealizacion=0;
            int opcion=1;
            while(opcion!=0){
                Console.WriteLine("Ingrese el presupuesto total:");
                PresupuestoDelProyecto = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese las horas de realización del edificio total:");
                horasDeRealizacion = Int32.Parse(Console.ReadLine());
                EmpresaConstructora empresa = new EmpresaConstructora(PresupuestoDelProyecto,horasDeRealizacion);
                string palabra = empresa.sePuedeRealizarElProyecto() ? "SI" : "NO";
                Console.WriteLine("El presupuesto "+palabra+" alcanza.");
                Console.WriteLine("\n(0)Salir\n(1)Ingresar otro proyecto");
                opcion = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
