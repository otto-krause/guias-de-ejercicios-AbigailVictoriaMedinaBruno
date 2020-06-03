using System;

namespace E1
{
    class Program
    {
        static void opcionAnimal(Animal animal){
            int opcion1=0;
            do{
                Console.WriteLine("\n(1)Darle de comer"+
                "\n(2)Jugar"+
                "\n(3)Dormir"+
                "\n(4)Mostrar energia"+
                "\nCualquier otra tecla para salr.");
                opcion1 = Int32.Parse(Console.ReadLine());
                switch(opcion1){
                    case 1:animal.comer();
                        break;
                    case 2:animal.jugar();
                        break;
                    case 3:animal.dormir();
                        break;
                    case 4:Console.WriteLine("La energia actual es: " + animal.mostrarEnergia());
                        break;
                    default: opcion1 = 0; break;
                }
            }while(opcion1 != 0);
        }
        static void Main(string[] args)
        {
            int opcion=0;
            Animal pajaro = new Pajaro();
            Animal perro = new Perro();
            do{
                Console.WriteLine("\n¿Con qué animal desea interactuar?");
                Console.WriteLine("\n(1)Pajaro\n(2)Perro\nCualquier numero para salir");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1: opcionAnimal(pajaro);
                        break;
                    case 2: opcionAnimal(perro);
                        break;
                    default: opcion = 0; break;
                }
            }while(opcion != 0);
        }
    }
}
