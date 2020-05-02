using System;
using System.Collections.Generic;
namespace E6
{
    public class Calificacion
    {
        private int estrellas=0;
        public int Estrellas { get => estrellas;}
        private string reseña;
        public string Reseña { get => reseña;}

        public Calificacion(int estrellas, string reseña)
        {
            this.estrellas = estrellas;
            this.reseña = reseña;
        }

    }
}