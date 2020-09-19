using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Barrios
    {
        List<Niño> listaDeNiños;
        public Barrios(List<Niño> listaDeNiños)
        {
            this.listaDeNiños = listaDeNiños;
        }
        public List<Niño> tresNiñosQueMasCaramelosTienen(){
            listaDeNiños.OrderBy(niño => niño.Bolsa).ToList();
            List<Niño> tresNiños = listaDeNiños.Count() >= 3 ? listaDeNiños.GetRange(0,2) : listaDeNiños;
            return tresNiños;
        }
        public List<Traje> trajesUsadosPorNiñosConMasDe10Caramelos(){
            List<Niño> niños10caramelos = listaDeNiños.Where(niño => niño.Bolsa > 10).ToList();
            List<Traje> trajesUsados = niños10caramelos.Select(niño => niño.Traje).Distinct().ToList();
            return trajesUsados;
        }
       
    }
}