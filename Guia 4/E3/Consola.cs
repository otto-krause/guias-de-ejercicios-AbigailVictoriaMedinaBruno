using System;
using System.Collections.Generic;
namespace E3
{
    public class Consola
    {
        protected List<Juego> listaDeJuegos;
        protected int puntos;
        protected string nombre;

        public string Nombre { get => nombre; }

        public Consola(string nombre){
            this.nombre = nombre;
            this.puntos = 0;
            listaDeJuegos = new List<Juego>();
        }
        public virtual void agregarJuego(Juego juegoNuevo){
            int repetido=0;
            foreach(Juego juegoAux in listaDeJuegos){
  /**/          Console.WriteLine(juegoAux);
                if(juegoAux.Nombre == juegoNuevo.Nombre)
                    repetido=1;
            }
            if(repetido != 1)
                listaDeJuegos.Add(juegoNuevo);
        }
        public virtual void jugar(int horasDeJuego){
            puntos += 4*horasDeJuego;
        }
        public virtual int revisarPuntaje() {return puntos;}
        public Juego elMasNuevo(){
            int añoReciente = 0;
            Juego juegoReciente = new Juego("",0,"");
            foreach(Juego juegoAux in listaDeJuegos){
                if(añoReciente < juegoAux.AñoDeLanzamiento){
                    añoReciente = juegoAux.AñoDeLanzamiento;
                    juegoReciente = juegoAux;
                }
            }
            return juegoReciente;
        }
        public Juego elMasViejo(){
            int añoAntiguo = 0;
            Juego juegoAntiguo = new Juego("",0,"");
            foreach(Juego juegoAux in listaDeJuegos){
                if(añoAntiguo != 0){
                    if(añoAntiguo > juegoAux.AñoDeLanzamiento){
                        añoAntiguo = juegoAux.AñoDeLanzamiento;
                        juegoAntiguo = juegoAux;
                    }
                }
                else{
                    añoAntiguo = juegoAux.AñoDeLanzamiento;
                    juegoAntiguo = juegoAux;
                }
            }
            return juegoAntiguo;
        }

    }
}