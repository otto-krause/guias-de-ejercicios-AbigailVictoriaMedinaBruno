using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Ejercicio
{
    public class Coordenadas
    {
        
        [JsonProperty("latitud")]
        public float latitud{ get; set; }
        [JsonProperty("longitud")]
        public float longitud{ get; set; }

        /*public Coordenadas(int latitud,int longitud)
        {
            this.latitud = latitud;
            this.longitud = longitud;
        }*/
    }
}