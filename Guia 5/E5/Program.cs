using System;
using System.Collections.Generic;
using System.Linq;
namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> conocimientos1 = new List<string>{"agua","bol","depilación","cartillo","expiración","celeste","falso","verdadero"};
            //List<string> conocimientos2 = new List<string>{"agua","fornite","pepe","celeste","amistad","azul","celular","amor"};
            //List<string> conocimientos3 = new List<string>{"respirar","comer","cerrar","tinte","morado","nueve","ocho","liso"};

            Persona pablo = new Persona(conocimientos1);

            Console.WriteLine("\nLos Ultimos 5 conocimientos adquiridos:");
            pablo.ultimos5Conocimientos().ForEach(i => Console.WriteLine(i));

            Console.WriteLine("\nLos primeros 4 conocimientos en orden alfabetico:");
            pablo.primeros4Conocimientos().ForEach(j => Console.WriteLine(j));

            Console.WriteLine("\n"+ pablo.cuantosTienenCion() +" palabras contienen 'ción'.");
            


        }
    }
}
