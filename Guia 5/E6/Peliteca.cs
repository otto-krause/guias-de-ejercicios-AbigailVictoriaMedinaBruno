using System;
using System.Collections.Generic;
using System.Linq;
namespace E6
{
    public class Peliteca
    {
        public List<Pelicula> peliculas;
        public List<Pelicula> aux;
        public Peliteca(){
            
            aux = new List<Pelicula>();

            Pelicula shrek = new Pelicula("Shrek","Comedia","Andrew Adamson",2001);
            Pelicula shrek2 = new Pelicula("Shrek 2","Comedia","Andrew Adamson",2004);
            Pelicula shrek3 = new Pelicula("Shrek tercero","Comedia","Chris Miller",2007);
            
            Pelicula actividadParanormal = new Pelicula("Actividad Paranormal","Terror","Oren Peli",2009);
            Pelicula actividadParanormal2 = new Pelicula("Actividad Paranormal 2","Terror","Tod Williams",2010);
            Pelicula laMonja = new Pelicula("La Monja","Terro","Corin Hardy",2018);

            Pelicula miGranBodaGriega = new Pelicula("Mi Gran Boda Griega","Comedia Romantica","Joel Zwick",2002);
            Pelicula miGranBodaGriega2 = new Pelicula("Mi Gran Boda Griega 2","Comedia Romantica","Kirk Jones",2016);
            Pelicula laPropuesta = new Pelicula("La Propuesta","Comedia Romantica","Anne Fletcher",2009);
             
            peliculas = new List<Pelicula>{shrek,shrek2,shrek3,actividadParanormal,actividadParanormal2,
            laMonja,miGranBodaGriega,miGranBodaGriega2,laPropuesta};
        }
        public void porGenero(string genero){
            aux.Clear();
            aux = peliculas.Where(pelicula => pelicula.Genero.Contains(genero)).ToList();
        }
        public void porNombre(string nombre){
            aux.Clear();
            aux = peliculas.Where(pelicula => pelicula.Nombre.Contains(nombre)).ToList();
        }
        public void porAño(int año){
            aux.Clear();
            aux = peliculas.Where(pelicula => pelicula.Año == año).ToList();
        }
        public void porDirector(string director){
            aux.Clear();
            aux = peliculas.Where(pelicula => pelicula.Director == director).ToList();
        }

    }
}