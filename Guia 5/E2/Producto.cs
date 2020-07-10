using System;
using System.Collections.Generic;
using System.Linq;
namespace E2
{
    public class Producto
    {
        string nombre;
        public string Nombre { get => nombre;}
        double precio=0;
        public double Precio { get => precio;}
        public Producto(string nombre, double precio){
            this.nombre=nombre;
            this.precio=precio;
        }

    }
}