using System;

namespace E5
{
    class Program
    {
        //Abigail
        static void Main(string[] args)
        {
            int minutosDeEntrenamiento = 0;
            Falcon_Armor falcon_armor = new Falcon_Armor();
            Shadow_Armor shadow_armor = new Shadow_Armor();
            X x = new X(falcon_armor);
            int opcion = 0;
            do{
                Console.WriteLine("\n¿Qué desea hacer?"+
                "\n(1)Conocer mi fuerza."+
                "\n(2)Entrenar."+
                "\n(3)Cambiar a la Shadow Armor."+
                "\n(4)Cambiar a la Falcon Armor."+
                "\nIngrese cualquier otra tecla para salir.");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:
                        Console.WriteLine("La cantidad de fuerza que tiene es: "+ x.fuerza());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese los minutos de entrenamiento:");
                        minutosDeEntrenamiento = Int32.Parse(Console.ReadLine());
                        x.entrenar(minutosDeEntrenamiento);
                        Console.WriteLine("Entrenando.");
                        break;
                    case 3:
                        x.cambiarArmadura(shadow_armor);
                        Console.WriteLine("Se cambió a la Shadow Armor.");
                        break;
                    case 4:
                        x.cambiarArmadura(falcon_armor);
                        Console.WriteLine("Se cambió a la Falcon Armor.");
                        break;    
                    default:opcion=0;
                        break;
                }
            }while(opcion != 0);
        }
    }
}
