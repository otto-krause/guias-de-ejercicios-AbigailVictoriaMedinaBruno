using System;
using System.Collections.Generic;
namespace E6
{
    public class Steam
    {
        List<Calificacion> listaDeCalificacion = new List<Calificacion>();
        private List<Juego> listaDeJuego = new List<Juego>();
        public List<Juego> ListaDeJuego { get => listaDeJuego; }
        private List<Juego> alta = new List<Juego>();
        public List<Juego> Alta { get => alta; }
        private List<Juego> baja = new List<Juego>();
        public List<Juego> Baja { get => baja; }
        private List<Juego> media = new List<Juego>();
        public List<Juego> Media { get => media; }

        public Steam(){
            Calificacion calCOD1 = new Calificacion(7,"Muy bien desarrollado con buena trama");
            Calificacion calCOD2 = new Calificacion(6,"Poco original");
            Calificacion calCOD3 = new Calificacion(7,"Buena historia poca jugabilidad");
            listaDeCalificacion.Add(calCOD1);
            listaDeCalificacion.Add(calCOD2);
            listaDeCalificacion.Add(calCOD3);
            Juego callOfDuty = new Juego("Call of Duty","Accion",listaDeCalificacion);

            listaDeCalificacion.Clear();

            Calificacion calLBP1 = new Calificacion(9,"Excelente jugabilidad para menores");
            Calificacion calLBP2 = new Calificacion(8,"Muchos colores pero entretenido");
            Calificacion calLBP3 = new Calificacion(6,"Buen juego para menores pero poca historia");
            listaDeCalificacion.Add(calLBP1);
            listaDeCalificacion.Add(calLBP2);
            listaDeCalificacion.Add(calLBP3);
            Juego littleBigPlanet = new Juego("Little Big Planet","Imaginacion",listaDeCalificacion);

            listaDeCalificacion.Clear();

            Calificacion calMC1 = new Calificacion(10,"Uno de los mejores juegos de combate");
            Calificacion calMC2 = new Calificacion(8,"Buena trama y buena disponibilidad de multijugador");
            Calificacion calMC3 = new Calificacion(9,"Excelente multijugador aunque malos graficos");
            listaDeCalificacion.Add(calMC1);
            listaDeCalificacion.Add(calMC2);
            listaDeCalificacion.Add(calMC3);
            Juego mortalCombat = new Juego("Mortal Combat","Combate",listaDeCalificacion);

            listaDeJuego.Add(callOfDuty);
            listaDeJuego.Add(littleBigPlanet);
            listaDeJuego.Add(mortalCombat);
        }
        private void promedio(){
            int promedio1=0;
            foreach(Juego i in listaDeJuego){
                foreach(Calificacion j in i.ListaDeCalificaciones){
                    promedio1+=j.Estrellas;
                }
                promedio1/=i.ListaDeCalificaciones.Count;
                if(promedio1>=4)
                    alta.Add(i);
                if(promedio1==3)
                    media.Add(i);
                if(promedio1<=2)
                    baja.Add(i);

            }
                
        }
        public List<Juego> porGenero(string genero){
            List<Juego> lista = new List<Juego>();
            foreach(Juego aux in listaDeJuego){
                if(aux.Genero == genero){
                    lista.Add(aux);        
                }
            }
            return lista;
        }
        public List<Juego> porCalificacion(string cali){
            promedio();
            switch(cali){
                case "alta": return alta;
                case "media": return media;
                case "baja": return baja;
                default: return null;}
        }
    }
}