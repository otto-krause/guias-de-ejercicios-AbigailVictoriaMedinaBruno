using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            float latitud;
            float longitud;
            string jsonString="";
            string json = "C:\\Users\\vmedina\\Downloads\\Ejemplo.json";
            
            jsonString = File.ReadAllText("C:\\Users\\vmedina\\Downloads\\Ejemplo2.json");
            //List<Locales> locales = JsonConvert.DeserializeObject<List<Locales>>(jsonString);
            Empresa myEmpresa = JsonConvert.DeserializeObject<Empresa>(jsonString);
            Coordenadas coor = new Coordenadas();
            Console.WriteLine("Ingrese las coordenadas del Usuario: ");
            Console.WriteLine("Latitud: ");
            coor.latitud =   float.Parse(Console.ReadLine());
            Console.WriteLine("Longitud: ");
            coor.longitud  =  float.Parse(Console.ReadLine());
            Usuario usuario = new Usuario(coor);
            Console.WriteLine("Buscar local más cercano:");
            Locales localAux = myEmpresa.localMasCercano(usuario);
            Console.WriteLine("Nombre:"+localAux.nombre+ "\nDireccion:" + localAux.direccion);
             Console.WriteLine("Buscar locales con puestos disponibles");
            localAux = myEmpresa.encontrarPuesto(usuario);
            Console.WriteLine("Nombre:"+localAux.nombre+ "\nDireccion:" + localAux.direccion);
            
        }
    }
}
/*Me instale la libreria de Newtonsoft.Json para poder desearlizar el json
para ello ejecute la siguiente instrucción en la terminal de VSCODE: dotnet add package Newtonsoft.Json
googleando un poco encontré ejemplos de ésta librería y funcionó
*/
