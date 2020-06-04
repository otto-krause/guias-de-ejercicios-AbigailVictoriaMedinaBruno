using System;
using System.Collections.Generic;
namespace E3
{
    public class Juego
    {
        string nombre;
        int añoDeLanzamiento;
        string nombreDeConsola;

        public Juego(string nombre, int añoDeLanzamiento, string nombreDeConsola)
        {
            this.nombre = nombre;
            this.añoDeLanzamiento = añoDeLanzamiento;
            this.nombreDeConsola = nombreDeConsola;
        }

        public string Nombre { get => nombre; }
        public string NombreDeConsola { get => nombreDeConsola; }
        public int AñoDeLanzamiento { get => añoDeLanzamiento; }
    }
}