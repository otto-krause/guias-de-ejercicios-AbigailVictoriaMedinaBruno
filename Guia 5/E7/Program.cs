using System;
using System.Collections.Generic;
using System.Linq;
namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Red_Social facebook = new Red_Social();
            List<Foto> listaDeFotos = new List<Foto>();
            List<string> lista = new List<string>();

            Console.WriteLine("\nFotos etiquetados: ");
            listaDeFotos = facebook.fotosEtiquetadas("Viviana Barreto","Pedro Alves");
            if(listaDeFotos != null){
                listaDeFotos.ForEach(foto => Console.WriteLine("Directorio de almacenamiento: " 
                + foto.DirectorioDeAlmacenamiento +
                " | Fecha de creacion: "+ foto.FechaDeCreacion));
            }
            else
                Console.WriteLine("No hay fotos con los dos etiquetados.");
            
            Console.WriteLine("\nFotos del año: ");
            listaDeFotos = facebook.fotosUltimoAño("Viviana Barreto");
            if(listaDeFotos != null)
                listaDeFotos.ForEach(foto => Console.WriteLine("Directorio de almacenamiento: " 
                + foto.DirectorioDeAlmacenamiento +
                " | Fecha de creacion: "+ foto.FechaDeCreacion));
            else
                Console.WriteLine("No hay fotos del ultimo año de esta persona.");

            Console.WriteLine("\nPublicaciones 300 caracteres.");
            if(facebook.publicacionesDeMas300Caracteres() != null)
                facebook.publicacionesDeMas300Caracteres().ForEach(i => Console.WriteLine(i));
            else 
                Console.WriteLine("No hay publicaciones mayores a 300 caracteres.");
        }
    }
}
