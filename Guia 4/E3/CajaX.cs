using System;
using System.Collections.Generic;
namespace E3
{
    public class CajaX : Consola
    {
        public CajaX(string nombre) : base(nombre)
        {
        }

        public override void agregarJuego(Juego juegoNuevo)
        {
            base.agregarJuego(juegoNuevo);
            puntos += 25;
        }

    }
}