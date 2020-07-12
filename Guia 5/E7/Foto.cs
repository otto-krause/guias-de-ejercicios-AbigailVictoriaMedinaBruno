using System;
using System.Linq;
using System.Collections.Generic;
namespace E7
{
    public class Foto
    {
        string directorioDeAlmacenamiento;
        string fechaDeCreacion;
        List<string> personasEtiquetadas;

        public Foto(string directorioDeAlmacenamiento, string fechaDeCreacion, List<string> personasEtiquetadas)
        {
            this.directorioDeAlmacenamiento = directorioDeAlmacenamiento;
            this.fechaDeCreacion = fechaDeCreacion;
            this.personasEtiquetadas = personasEtiquetadas;
        }

        public string DirectorioDeAlmacenamiento { get => directorioDeAlmacenamiento; set => directorioDeAlmacenamiento = value; }
        public string FechaDeCreacion { get => fechaDeCreacion; set => fechaDeCreacion = value; }
        public List<string> PersonasEtiquetadas { get => personasEtiquetadas; set => personasEtiquetadas = value; }
    }
}