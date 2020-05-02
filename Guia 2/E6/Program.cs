using System;
using System.Collections.Generic;

namespace E6
{
    class Program
    {
        static string ingreso(){
            string palabra;
            Console.WriteLine("Ingrese lo que busca:");
            palabra=Console.ReadLine();
            return palabra;
        }
        static void mostrar(List<Juego> lista)
        {
            Console.WriteLine("\nJuegos:");
            foreach (Juego i in lista)
            {
                Console.WriteLine("Título: "+ i.Titulo +" / Género: "+ i.Genero);
                foreach(Calificacion j in i.ListaDeCalificaciones){
                    Console.WriteLine("\tEstrellas: "+j.Estrellas+" / Reseña: "+j.Reseña);
                }
            }
        }
        static void Main(string[] args)
        {
            Steam steam = new Steam();
            List<Juego> lista = new List<Juego>();
            int numero = 1;
            while(numero != 0){
                lista.Clear();
                Console.WriteLine("¿Cómo desea buscar los juegos?\n(0)Salir\n(1)Género\n(2)Calificación");
                numero = Int32.Parse(Console.ReadLine());
                switch(numero){
                    case 1:
                        lista = steam.porGenero(ingreso());
                        if(lista!=null)
                            mostrar(lista);
                        else
                            Console.WriteLine("No se encontro juego con ese género.");
                        break;
                    case 2:
                        lista = steam.porCalificacion(ingreso());
                        if(lista!=null)
                            mostrar(lista);
                        else
                            Console.WriteLine("No se encontro juego con esa calificación.");
                        break;

                }
            }
        }
    }
}
