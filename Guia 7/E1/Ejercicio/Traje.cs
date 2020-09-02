using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Traje
    {
        int resistencia;
        List<Arma> listaDeArmas;

        public Traje(int resistencia, List<Arma> listaDeArmas)
        {
            this.resistencia = resistencia;
            this.listaDeArmas = listaDeArmas;
        }

        public int Resistencia { get => resistencia; }
        public List<Arma> ListaDeArmas { get => listaDeArmas; }
    }
}