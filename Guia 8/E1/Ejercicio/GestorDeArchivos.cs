using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Ejercicio
{
    public class GestorDeArchivos
    {
        string fileName;
        StreamWriter fichero;
        StreamReader fichero2;
        List<string> nombresDeLaPeliculas;
        string linea;
        public string FileName { get => fileName;}
        public StreamWriter Fichero { get => fichero;}
        public List<string> NombresDeLaPeliculas{ get => nombresDeLaPeliculas; }

        public GestorDeArchivos(string nombreArchivo)
        {       
            if (fichero != null)
            {
                fichero.Close();
            }    
            nombresDeLaPeliculas = new List<string>();
            fichero = null;
            fileName = nombreArchivo;
            try {
                fichero = File.CreateText(FileName);
            }  catch (Exception exp) {
                Console.WriteLine("Error");
            return;
            }    
        }
        public void agregarPeliculaArchivo(string nombrePelicula)
        {
            if (fichero != null)
            {
                fichero.Close();
            }    
            fichero = File.AppendText(FileName);
            fichero.WriteLine(nombrePelicula);
            nombresDeLaPeliculas.Add(nombrePelicula);
        }
        public void mostrarTodoElArchivo()
        {
            if (fichero != null)
            {
                fichero.Close();
            } 
            try {
                fichero2 = File.OpenText(fileName);
            } catch (PathTooLongException exp) {
                Console.WriteLine("Error");
                return;
            } catch (IOException exp) {
                Console.WriteLine("Error");
                return;
            } catch (Exception exp) {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Películas:");
            do{
                linea = fichero2.ReadLine();
                Console.WriteLine(linea);
            }while(linea != null);        
        }    
        public void mostrarSinRepetir()
        {
            if (fichero != null)
            {
                fichero.Close();
            } 
            nombresDeLaPeliculas.Clear();
            try {
                fichero2 = File.OpenText(fileName);
            } catch (PathTooLongException exp) {
                Console.WriteLine("Error");
                return;
            } catch (IOException exp) {
                Console.WriteLine("Error");
                return;
            } catch (Exception exp) {
                Console.WriteLine("Error");
                return;
            }
            while ((linea = fichero2.ReadLine()) != null)
            {
                nombresDeLaPeliculas.Add(linea);
            }
            Console.WriteLine("Películas sin repetir:");
            nombresDeLaPeliculas.Distinct().ToList().ForEach(i => Console.WriteLine(i));
        
        }        
        
        public void buscarPelicula(string buscar)
        {
            if (fichero != null)
            {
                fichero.Close();
            } 
            nombresDeLaPeliculas.Clear();
            try {
                fichero2 = File.OpenText(fileName);
            } catch (PathTooLongException exp) {
                Console.WriteLine("Error");
                return;
            } catch (IOException exp) {
                Console.WriteLine("Error");
                return;
            } catch (Exception exp) {
                Console.WriteLine("Error");
                return;
            }
            while ((linea = fichero2.ReadLine()) != null)
            {
                nombresDeLaPeliculas.Add(linea);
            }
            Console.WriteLine("Peliculas Encontradas:");
            nombresDeLaPeliculas.Where(x => x.Contains(buscar)).ToList().ForEach(i => Console.WriteLine(i));                 
        } 

    }
}