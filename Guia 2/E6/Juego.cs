using System;
using System.Collections.Generic;
namespace E6
{
    public class Juego
    {
        private string titulo;
        public string Titulo { get => titulo; }
        private string genero;
        public string Genero { get => genero; }
        private List<Calificacion> listaDeCalificaciones = new List<Calificacion>();
        public List<Calificacion> ListaDeCalificaciones { get => listaDeCalificaciones; }


        public Juego(string titulo, string genero, List<Calificacion> listaDeCalificaciones)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.listaDeCalificaciones = listaDeCalificaciones;
        }

        
        
    }
}