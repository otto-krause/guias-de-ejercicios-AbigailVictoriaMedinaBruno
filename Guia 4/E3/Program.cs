using System;

namespace E3
{
    class Program
    {
        static void añadirJuego(Jugador jugador){
            string nombre;
            int año = 0;
            string consolaPredeterminada;
            Console.WriteLine("\nIngrese el nombre del juego:");
            nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese el año de lanzamiento:");
            año = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la consola con la cual se usa:");
            consolaPredeterminada = Console.ReadLine();
            Juego nuevoJuego = new Juego(nombre,año,consolaPredeterminada);
            jugador.adquirirJuego(nuevoJuego);        
        }
        static void accionesConsola(string nombreConsola,Jugador jugador){
            int opcion1 = 0;
            int horas = 0;
            Consola consolaSeleccionada = new Consola("");
            foreach(Consola consolaAux in jugador.ListaDeConsolas){
                if(nombreConsola == consolaAux.Nombre)
                    consolaSeleccionada = consolaAux;
            }
            Juego juego = new Juego("",0,"");
            do{
                Console.WriteLine("\n¿Qué desea hacer?"+
                "\n(1)Ver el juego más viejo"+
                "\n(2)Ver el juego más nuevo"+
                "\n(3)Jugar"+
                "\nCualquier otra tecla para salir.");
                opcion1 = Int32.Parse(Console.ReadLine());
                switch(opcion1){
                    case 1: juego = consolaSeleccionada.elMasViejo();
                    Console.WriteLine("Nombre: "+juego.Nombre+ 
                    "/Año de lanzamiento: "+juego.AñoDeLanzamiento+
                    "/Consola: "+juego.NombreDeConsola);
                        break;
                    case 2: juego = consolaSeleccionada.elMasNuevo();
                    Console.WriteLine("Nombre: "+juego.Nombre+ 
                    "/Año de lanzamiento: "+juego.AñoDeLanzamiento+
                    "/Consola: "+juego.NombreDeConsola);
                        break;
                    case 3: Console.WriteLine("Ingrese las horas jugadas:");
                        horas = Int32.Parse(Console.ReadLine());
                        consolaSeleccionada.jugar(horas);
                        break;
                    default: opcion1 = 0; break;
                }
            }while(opcion1 != 0);
        }
        static void Main(string[] args)
        {
            Jugador Francisco = new Jugador("Francisco");
            int opcion=0;
            do{
                Console.WriteLine("\n¿Qué desea hacer?"+
                "\n(1)Adquirir un Juego"+
                "\n(2)Mostrar la consola más usada"+
                "\n(3)Acciones con Caja X"+
                "\n(4)Acciones con PC"+
                "\n(5)Acciones con Ponystation 4"+
                "\n(6)Acciones con Ponystation 4 pro SaladaEdition"+
                "\nCualquier otra tecla para salir.");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1: añadirJuego(Francisco);
                        break;
                    case 2: Console.WriteLine(Francisco.laMasUsada().Nombre+
                    " es la consola más usada.");
                        break;
                    case 3: accionesConsola("Caja X",Francisco);
                        break;
                    case 4: accionesConsola("PC",Francisco);
                        break;
                    case 5: accionesConsola("Ponystation 4",Francisco);
                        break;
                    case 6: accionesConsola("Ponystation4 pro SaladaEdition",Francisco);
                        break;
                    default: opcion = 0; break;
                }
            }while(opcion != 0);
        }
    }
}
