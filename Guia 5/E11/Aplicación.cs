using System;
using System.Collections.Generic;
using System.Linq;
namespace E11
{
    public class Aplicación
    {
        /*En android decidieron implementar un sistema de reconocimiento de aplicaciones según su uso.
        Para ello pueden detectar algunas variables de cada aplicación como:
        tiempoDeUso, cantidadDeToquesEnLaPantalla, permisos (puede ser acceso a fotos, videos, contactos, etc.),
        tiempoDeUsoDelTeclado.*/
        string nombre;
        double tiempoDeUso;
        double cantidadDeToquesEnLaPantalla;
        List<string> permisos;
        double tiempoDeUsoDelTeclado;

        public Aplicación(string nombre, double tiempoDeUso, double cantidadDeToquesEnLaPantalla, List<string> permisos, double tiempoDeUsoDelTeclado)
        {
            this.nombre = nombre;
            this.tiempoDeUso = tiempoDeUso;
            this.cantidadDeToquesEnLaPantalla = cantidadDeToquesEnLaPantalla;
            this.permisos = permisos;
            this.tiempoDeUsoDelTeclado = tiempoDeUsoDelTeclado;
        }
        public string Nombre { get => nombre;}
        public double TiempoDeUso { get => tiempoDeUso;}
        public double CantidadDeToquesEnLaPantalla { get => cantidadDeToquesEnLaPantalla;}
        public List<string> Permisos { get => permisos; }
        public double TiempoDeUsoDelTeclado { get => tiempoDeUsoDelTeclado;  }
        /*Interacción: es la división entre la cantidadDeToquesEnLaPantalla y tiempoDeUso de la aplicación, 
        se mide en toques por segundo.
        Interacción con el teclado: es la división entre la tiempoDeUsoDelTeclado y tiempoDeUso de la aplicación,
        se mide en porcentaje.*/
        public double interaccion(){
                return cantidadDeToquesEnLaPantalla/tiempoDeUso;
        }
        public double interaccionConElTeclado(){
            return (tiempoDeUsoDelTeclado/TiempoDeUso)*100;
        }
    }
}