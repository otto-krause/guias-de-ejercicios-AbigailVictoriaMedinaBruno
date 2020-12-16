using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Ejercicio
{
    public class Empleado
    {
        [JsonProperty("puesto")]
        public string puesto{ get; set; }
        [JsonProperty("asignadoA")]
        public string asignadoA{ get; set; }
        /*
        public Empleado(string puesto, string asignadoA)
        {
            this.puesto = puesto;
            this.asignadoA = asignadoA;
        }*/
    }
}