using System;
using System.Collections.Generic;
using System.Linq;
namespace E11
{
    /*En android decidieron implementar un sistema de reconocimiento de aplicaciones según su uso.
    Para ello pueden detectar algunas variables de cada aplicación como:
    tiempoDeUso, cantidadDeToquesEnLaPantalla, permisos (puede ser acceso a fotos, videos, contactos, etc.),
    tiempoDeUsoDelTeclado.
        Para cada aplicación podremos calcular:
        Interacción: es la división entre la cantidadDeToquesEnLaPantalla y tiempoDeUso de la aplicación, 
        se mide en toques por segundo.
        Interacción con el teclado: es la división entre la tiempoDeUsoDelTeclado y tiempoDeUso de la aplicación,
        se mide en porcentaje.
        Estadísticamente se ha detectado que las aplicaciones que son Juegos tienen una interacción 
        aproximada de 25 toques por segundo.
        Y las aplicaciones que son redes sociales generalmente tienen permiso para fotos y videos y una interacción 
        con el teclado superior al 20%.
        Se pide que el sistema operativo puede listar/detectar para las aplicaciones de cada usuario:
        Cuales aplicaciones son Juegos.
        Cuales aplicaciones son Redes sociales.
        Cuales aplicaciones no pueden catalogarse como alguna de las anteriores.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Android sistemaOperativo = new Android();
            Console.WriteLine("\nLos juegos dentro de sistema son: ");
            sistemaOperativo.cualesSonJuegos().ForEach(app => Console.WriteLine(app.Nombre));
            
            Console.WriteLine("\nLas redes sociales dentro de sistema son: ");
            sistemaOperativo.cualesSonRedes().ForEach(app => Console.WriteLine(app.Nombre));

            Console.WriteLine("\nOtras aplicaciones dentro de sistema son: ");
            sistemaOperativo.cualesSonOtros().ForEach(app => Console.WriteLine(app.Nombre));
        }
    }
}
