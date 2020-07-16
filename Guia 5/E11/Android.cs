using System;
using System.Collections.Generic;
using System.Linq;
namespace E11
{
    public class Android
    {
        //double toquesPorSegundo;
        /*Para cada aplicación podremos calcular:
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
        Cuales aplicaciones no pueden catalogarse como alguna de las anteriores.*/
        List<Aplicación> todasLasAplicaciones;
        Aplicación candyCrush;
        Aplicación instagram;
        Aplicación blocDeNotas;

        public Android(){
            candyCrush = new Aplicación("Candy Crush",2,50,new List<string>{"contactos"},0);
            instagram = new Aplicación("Instagram",5,30,new List<string>{"fotos","videos","mensajes","archivos","contactos"},3);
            blocDeNotas = new Aplicación("Bloc de Notas",1,20,new List<string>{"contactos","mensajes"},1);
            todasLasAplicaciones = new List<Aplicación>{candyCrush,instagram,blocDeNotas};
            
        }
        public List<Aplicación> cualesSonJuegos(){
            //Estadísticamente se ha detectado que las aplicaciones que son Juegos tienen una interacción 
            //aproximada de 25 toques por segundo.
            return todasLasAplicaciones.Where(app => app.interaccion() >= 24 && app.interaccion() <= 26).ToList();
        }
        public List<Aplicación> cualesSonRedes(){
            //Y las aplicaciones que son redes sociales generalmente tienen permiso para fotos y videos y una interacción 
            //con el teclado superior al 20%.
            return todasLasAplicaciones.Where(app => app.Permisos.Contains("videos") && app.Permisos.Contains("fotos") && app.interaccionConElTeclado() > 20).ToList();
        } 
        public List<Aplicación> cualesSonOtros(){
            return todasLasAplicaciones.Where(app => !(app.Permisos.Any(i => i == "videos") && app.Permisos.Any(i => i == "fotos") && (app.interaccionConElTeclado()>20)) && !(app.interaccion() >= 24 && app.interaccion() <= 26)).ToList();
        }


    }
}