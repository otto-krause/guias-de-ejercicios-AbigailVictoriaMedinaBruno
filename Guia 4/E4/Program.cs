using System;
using System.Collections.Generic;
namespace E4
{
    class Program
    {
        static void interaccionEmpleado(Empleado empleado,int numero){
            int opcion1 = 0;
            int extracción = 0;
            int personasReferidas = 0;
            do{
                Console.WriteLine("\n¿Qué desea hacer?"+
                "\n(1)Depositar"+
                "\n(2)Extraer"+
                "\n(3)Mostrar cuenta bancaria"+
                "\nCualquier otra tecla para salir.");
                opcion1 = Int32.Parse(Console.ReadLine());
                switch(opcion1){
                    case 1: if(numero != 1)
                                empleado.depositar(0);
                            else{
                                    Console.WriteLine("Ingrese las personas referidas:");
                                    personasReferidas = Int32.Parse(Console.ReadLine());
                                    empleado.depositar(personasReferidas);
                                }
                        break;
                    case 2: Console.WriteLine("Ingrese cuanto desea extraer:");
                            extracción = Int32.Parse(Console.ReadLine());
                            empleado.extraer(extracción);
                        break;
                    case 3: Console.WriteLine("Cuenta bancaria: $"+empleado.mostrarCajaBancaria());
                        break;
                    default: opcion1 = 0; break;
                }
            }while(opcion1 != 0);
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            RRHH rrhh = new RRHH();
            Programador programador = new Programador("junior");
            Administrativo administrador = new Administrativo();
            do{
                Console.WriteLine("\n¿Qué es?"+
                "\n(1)RRHH"+
                "\n(2)Programador"+
                "\n(3)Administrador"+
                "\nCualquier otra tecla para salir.");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1: interaccionEmpleado(rrhh,1);
                        break;
                    case 2: interaccionEmpleado(programador,2);
                        break;
                    case 3: interaccionEmpleado(administrador,3);
                        break;
                    default: opcion = 0; break;
                }
            }while(opcion != 0);
        }
    }
}
