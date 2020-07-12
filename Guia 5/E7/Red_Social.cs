using System;
using System.Linq;
using System.Collections.Generic;
namespace E7
{
    public class Red_Social
    {
        DateTime fechaActual = DateTime.Today;
        Cuenta maria;
        Cuenta viviana;
        Cuenta pedro;
        Foto foto1;
        Foto foto2;
        Foto foto3;
        Foto foto4;
        List<string> amigos; 
        List<string> publicaciones;
        List<string> publicacionesTotales;
        List<Foto> albumDeFotos;
        List<Foto> fotosTotal;
        List<Cuenta> personasTotal;
        public Red_Social(){

            foto1 = new Foto("C:/storage/DCIM","18-03-2003",new List<string>{"Maria Lombardo","Viviana Barreto","Pedro Alves"});
            foto2 = new Foto("C:/storage/DCIM","20-01-2020",new List<string>{"Viviana Barreto","Pedro Alves"});
            foto3 = new Foto("C:/storage/DCIM","15-02-2020",new List<string>{"Maria Lombardo","Viviana Barreto"});
            foto4 = new Foto("C:/storage/DCIM","22-08-2007",new List<string>{"Maria Lombardo","Pedro Alves"});
            
            fotosTotal = new List<Foto>{foto1,foto2,foto3,foto4};

            publicaciones = new List<string>{"La re concha de tu madre, la tuya con vinagre. La reconcha de tu hermana, la tuya con banana",
            "hoy desperté feliz"};
            albumDeFotos = new List<Foto>{foto1,foto3,foto4};
            amigos = new List<string>{"Viviana Barreto","Pedro Alves"};
            maria = new Cuenta("Maria Lombardo",amigos,publicaciones,albumDeFotos);

            publicaciones = new List<string>{"que onda? perri",
            "hoy a mimir, mañana a morir"};
            albumDeFotos = new List<Foto>{foto1,foto2,foto3};
            amigos = new List<string>{"Maria Lombardo","Pedro Alves"};
            viviana = new Cuenta("Viviana Barreto",amigos,publicaciones,albumDeFotos);

            publicaciones = new List<string>{"tumama",
            "hoy voy a llorar todo el día"};
            albumDeFotos = new List<Foto>{foto1,foto2,foto4};
            amigos = new List<string>{"Maria Lombardo","Viviana Barreto"};
            pedro = new Cuenta("Pedro Alves",amigos,publicaciones,albumDeFotos);
            
            personasTotal = new List<Cuenta>{maria,viviana,pedro};
            publicacionesTotales = new List<string>{"La re concha de tu madre, la tuya con vinagre. La reconcha de tu hermana, la tuya con banana",
            "hoy desperté feliz","que onda? perri",
            "hoy a mimir, mañana a morir","tumama",
            "hoy voy a llorar todo el día"};
        }
        public List<Foto> fotosUltimoAño(string persona){
            List<Foto> fotoAux = new List<Foto>();
            fotoAux = fotosTotal.Where(foto => foto.PersonasEtiquetadas.Contains(persona) 
            && foto.FechaDeCreacion.Contains("2020"))
            .ToList();
            return fotoAux = fotoAux.Count()>0 ? fotoAux : null;  
        }
        //Dadas dos personas, ver las fotos en las que ambas están etiquetadas.
        //Ver todas las publicaciones que contengan más de 300 caracteres.

        public List<Foto> fotosEtiquetadas(string persona1, string persona2){
            List<Foto> fotoAux1 = new List<Foto>();
            fotoAux1 = fotosTotal.Where(foto => foto.
            PersonasEtiquetadas.Contains(persona1) && foto.PersonasEtiquetadas.Contains(persona2)).ToList();
            return fotoAux1 = fotoAux1.Count()>0 ? fotoAux1 : null;
        }
        public List<string> publicacionesDeMas300Caracteres(){
            List<string> publicacionesAux = new List<string>();
            publicacionesAux = publicacionesTotales.Where(publicacion => publicacion.Count() > 300).ToList();
            return publicacionesAux = publicacionesAux.Count() > 0 ? publicacionesAux : null;
        }
    }
}