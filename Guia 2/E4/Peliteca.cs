using System;
using System.Collections.Generic;
namespace E4
{
    public class Peliteca
    {
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<Pelicula> aux = new List<Pelicula>();
        public Peliteca(){
            Pelicula shrek = new Pelicula("Shrek","Comedia","Andrew Adamson",2001);
            Pelicula shrek2 = new Pelicula("Shrek 2","Comedia","Andrew Adamson",2004);
            Pelicula shrek3 = new Pelicula("Shrek tercero","Comedia","Chris Miller",2007);
            
            Pelicula actividadParanormal = new Pelicula("Actividad Paranormal","Terror","Oren Peli",2009);
            Pelicula actividadParanormal2 = new Pelicula("Actividad Paranormal 2","Terror","Tod Williams",2010);
            Pelicula laMonja = new Pelicula("La Monja","Terro","Corin Hardy",2018);

            Pelicula miGranBodaGriega = new Pelicula("Mi Gran Boda Griega","Comedia Romantica","Joel Zwick",2002);
            Pelicula miGranBodaGriega2 = new Pelicula("Mi Gran Boda Griega 2","Comedia Romantica","Kirk Jones",2016);
            Pelicula laPropuesta = new Pelicula("La Propuesta","Comedia Romantica","Anne Fletcher",2009);
             
            peliculas.Add(shrek);
            peliculas.Add(shrek2);
            peliculas.Add(shrek3);
            peliculas.Add(actividadParanormal);
            peliculas.Add(actividadParanormal2);
            peliculas.Add(laMonja);
            peliculas.Add(miGranBodaGriega);
            peliculas.Add(miGranBodaGriega2);
            peliculas.Add(laPropuesta);
        }
        public void porGenero(string genero){
            aux.Clear();
            foreach (Pelicula i in peliculas){
                if(i.genero == genero)
                    aux.Add(i);
            }
        }
        public void porNombre(string nombre){
            aux.Clear();
            foreach (Pelicula i in peliculas){
                if(i.nombre == nombre)
                    aux.Add(i);
            }
        }
        public void porAño(int año){
            aux.Clear();
            foreach (Pelicula i in peliculas){
                if(i.año == año)
                    aux.Add(i);
            }
        }
        public void porDirector(string director){
            aux.Clear();
            foreach (Pelicula i in peliculas){
                if(i.director == director)
                    aux.Add(i);
            }
        }

    }
}