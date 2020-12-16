using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Ejercicio
{
    public class Locales
    {
        [JsonProperty("coordenadas")]
        public Coordenadas coordenadas{ get; set; }
        [JsonProperty("nombre")]
        public string nombre{ get; set; }
        [JsonProperty("direccion")]
        public string direccion{ get; set; }
        [JsonProperty("empleados")]
        public List<Empleado> empleados{ get; set; }
       
        /*public Locales(Coordenadas coordenadas,string nombre,string direccion,List<Empleado> empleados)
        {
            this.coordenadas = coordenadas;
            this.nombre = nombre;
            this.direccion = direccion;
            this.empleados = empleados;
        }*/

    }
}