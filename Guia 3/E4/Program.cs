using System;

namespace E4
{
    class Program
    {
        static void elTragalibros(Tragalibros persona){
            int opcion=0;
            string titulo;
            string autor;
            do{
                Console.WriteLine("\n¿Qué desea hacer?"+
                "\n(1)Leer un libro"+
                "\n(2)Calcular CI"+
                "\nIngrese cualquier otra tecla para salir.");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:
                        Console.WriteLine("Ingrese el titulo del libro:");
                        titulo = Console.ReadLine();
                        Console.WriteLine("Ingrese el autor del libro:");
                        autor = Console.ReadLine();
                        persona.leer(new Libro(titulo,autor));
                        break;
                    case 2:
                        Console.WriteLine("Su CI es: "+persona.calcularCI());
                        break;
                    default: opcion=0;
                        break;
                }
            }while(opcion != 0);    
        }
        static void Main(string[] args)
        {
            //Cualquier ejemplo utilizado tal vez no tiene ninguna relación con la realidad
            Tragalibros Gabriel = new Tragalibros();
            Tragalibros Fabricio = new Tragalibros();
            int opcion=0;
            do{    
                Console.WriteLine("\n¿A quién atendemos?"+
                "\n(1)Gabriel."+
                "\n(2)Fabricio."+
                "\nIngrese cualquier otra tecla para salir.");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:elTragalibros(Gabriel);
                        break;
                    case 2:elTragalibros(Fabricio);
                        break;
                    default: opcion=0;
                        break;
                }
            }while(opcion!=0);
        }
    }
}
