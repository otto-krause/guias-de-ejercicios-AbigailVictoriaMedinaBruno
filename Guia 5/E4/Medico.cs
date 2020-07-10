using System;
using System.Linq;
using System.Collections.Generic;
namespace E4
{
    public class Medico
    {
        private string nombre;
        private string apellido;
        private string especialidad;
        private int cantidadDeTurnos;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Especialidad { get => especialidad;}
        public int CantidadDeTurnos { get => cantidadDeTurnos; }

        public Medico(string nombre,string apellido,string especialidad,int cantidadDeTurnos){
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantidadDeTurnos=cantidadDeTurnos;
        }

        public bool estaDisponible(){ return cantidadDeTurnos<50; }

        public void asignarTurno() => cantidadDeTurnos++;
    }
}