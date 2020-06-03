using System;
using System.Collections.Generic;
namespace E4
{
    public class Tragalibros
    {
        List<Libro> listaDeLibrosLeidos;
        public Tragalibros(){
            listaDeLibrosLeidos = new List<Libro>();
        }
        public void leer(Libro libro){
            int contador = 0;
            foreach(Libro libroAux in listaDeLibrosLeidos){
                if(libro.Titulo == libroAux.Titulo && libro.Autor == libroAux.Autor)
                    contador++;
            }
            if(contador == 0)
                listaDeLibrosLeidos.Add(libro);
        }
        public int calcularCI(){
            int CI=listaDeLibrosLeidos.Count;
            return 5*CI;
        }
    }
} 