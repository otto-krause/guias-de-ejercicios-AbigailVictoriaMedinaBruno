using System;

namespace E5
{
    class Program
    {
        static void interaccionSerPensante(SerPensante unSer){
            int opcion1 = 0;
            string tema;
            do{
                Console.WriteLine("\n¿Qué desea hacer?"+
                "\n(1)Pensar"+
                "\n(2)Estudiar"+
                "\n(3)Mostrar puntos de inteligencia"+
                "\nCualquier otra tecla para salir.");
                opcion1 = Int32.Parse(Console.ReadLine());
                if(opcion1 == 2 || opcion1 == 1){
                    Console.WriteLine("Ingrese el tema a procesar: ");
                    tema = Console.ReadLine();
                }
                switch(opcion1){
                    case 1: unSer.pensar(tema);
                        break;
                    case 2: unSer.estudiar(tema);
                        break;
                    case 3: Console.WriteLine("Los puntos de inteligencia son: "+unSer.mostrarPuntosDeInteligencia());
                        break;
                    default: opcion1 = 0; break;
                }
            }while(opcion1 != 0);
        }
        static void Main(string[] args)
        {
            Robots robot = new Robots();
            Humano humano = new Humano();
            Cyborg cyborg = new Cyborg();       
            int opcion = 0;
            do{
                Console.WriteLine("\n¿Qué es?"+
                "\n(1)Robot"+
                "\n(2)Humano"+
                "\n(3)Cyborg"+
                "\nCualquier otra tecla para salir.");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:interaccionSerPensante(robot);
                        break;
                    case 2:interaccionSerPensante(humano);
                        break;
                    case 3:interaccionSerPensante(cyborg);
                        break;
                    default: opcion = 0; break;
                }
            }while(opcion != 0);
        }
    }
}
