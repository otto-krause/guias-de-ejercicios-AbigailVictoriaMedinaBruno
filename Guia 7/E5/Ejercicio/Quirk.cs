using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Quirk
    {
        int tiempoDeUso;
        string nombre;
        bool tieneConsecuencias;

        public Quirk(int tiempoDeUso, string nombre, bool tieneConsecuencias)
        {
            this.tiempoDeUso = tiempoDeUso;
            this.nombre = nombre;
            this.tieneConsecuencias = tieneConsecuencias;
        }

        public int poder(){
            return tiempoDeUso * nombre.Count();
        }
        public bool esPeligroso(){
            return (((poder()>1000) && (tiempoDeUso > 60)) || tieneConsecuencias);
        }
    }
}