using System;
using System.Collections.Generic;
namespace E3
{
    public class Jugador
    {
        string nombre;
        List<Consola> listaDeConsolas;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            listaDeConsolas = new List<Consola>();
            listaDeConsolas.Add(new CajaX("Caja X"));
            listaDeConsolas.Add(new PC("PC"));
            listaDeConsolas.Add(new Ponystation4("Ponystation 4"));
            listaDeConsolas.Add(new Ponystation4_pro_SaladaEdition("Ponystation4 pro SaladaEdition"));

        }

        public List<Consola> ListaDeConsolas { get => listaDeConsolas; }

        public void adquirirJuego(Juego juegoNuevo){
            foreach(Consola consolaAux in listaDeConsolas){
                if(juegoNuevo.NombreDeConsola == consolaAux.Nombre)
                    consolaAux.agregarJuego(juegoNuevo);
            }
        }
        public Consola laMasUsada(){
            int puntosMasAltos=0;
            Consola laConsolaMasUsada = new Consola("");
            foreach(Consola consolaAux in listaDeConsolas){
                if(consolaAux.revisarPuntaje()>puntosMasAltos){
                    puntosMasAltos = consolaAux.revisarPuntaje();
                    laConsolaMasUsada = consolaAux;
                }
            }
            return laConsolaMasUsada;
        }
    }
}