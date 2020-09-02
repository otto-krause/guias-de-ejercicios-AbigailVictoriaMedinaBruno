using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Arma
    {
        string marca;
        int cantidadDeBalas;

        public Arma(string marca, int cantidadDeBalas)
        {
            this.marca = marca;
            this.cantidadDeBalas = cantidadDeBalas;
        }
    }
}