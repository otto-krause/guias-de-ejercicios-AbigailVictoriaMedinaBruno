using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            string pelicula ="";
            Console.WriteLine("Ingrese el nombre del archivo");
            texto=Console.ReadLine(); 
            GestorDeArchivos gestor = new GestorDeArchivos(texto);
            do
            {
                Console.WriteLine("Ingrese la opcion:\n"+
                "1)Agregar Peliculas\n"+
                "2)Mostrar Contenido Entero\n"+
                "3)Mostrar sin Repetir\n"+
                "4)Buscar Pelicula");
                texto=Console.ReadLine();
                switch(texto)
                {
                    case "1":
                        do{
                            Console.WriteLine("Ingrese el nombre de la película:");
                            pelicula=Console.ReadLine();
                            gestor.agregarPeliculaArchivo(pelicula);
                            Console.WriteLine("Desea finalizar? ingrese 'S'");
                            texto=Console.ReadLine();
                        }while(texto!="S");
                    break; 
                    case "2":
                        gestor.mostrarTodoElArchivo();
                    break; 
                    case "3":
                        gestor.mostrarSinRepetir();
                    break; 
                    case "4":
                        Console.WriteLine("Ingrese lo que quiere buscar");
                        texto=Console.ReadLine();                            
                        gestor.buscarPelicula(texto);
                    break;
                }
                Console.WriteLine("Desea salir? 'SALIR'");
                texto=Console.ReadLine();                            
            } while (texto != "SALIR");
        }
    }
}
