using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Ejercicio
{
    public class Empresa
    {
        [JsonProperty("locales")]
        public List<Locales> locales { get ; set ; }
        
        public List<Locales> localesMasCercanos(Usuario usuarioExt){
            float cercano = 0;
            float coor = usuarioExt.coordenadas.latitud + usuarioExt.coordenadas.latitud;
            float coorL = 0;
            int indice = 5;
            List<Locales> localesAuxiliar = new List<Locales>();
            List<Locales> localesCercanos = new List<Locales>();
            Locales localAux;
            foreach (Locales l in locales)
            {
                localesAuxiliar.Add(l);
            }
            if(localesAuxiliar.Count()<5)
                indice = localesAuxiliar.Count();
            for(int i = 0; i<indice ; i++){
                localAux=null;
                cercano = 999;
                foreach (Locales L in localesAuxiliar)
                {
                    coorL=L.coordenadas.latitud + L.coordenadas.latitud;
                    if(cercano > (Math.Abs(coor-coorL))){
                        cercano = (Math.Abs(coor-coorL));
                        localAux = L;
                    }
                }
                localesCercanos.Add(localAux);
                localesAuxiliar.Remove(localAux);
            }
            return localesCercanos;
        }
        public Locales localMasCercano(Usuario usuarioExt){
            return localesMasCercanos(usuarioExt).First();
        }
        public Locales encontrarPuesto(Usuario usuarioExt){
            List<Locales> localesAux = localesMasCercanos(usuarioExt);
            foreach(Locales l in localesAux){
                if(l.empleados.Any(e => e.asignadoA == ""))
                    return l;
            }
            return null;
        }
    }
}