using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Mago
    {
        
        private Varita varitaDeHarry;
        private List<Receta> recetas;
        public Mago( Varita varitaDeHarry, List<Receta> recetas)
        {
            this.varitaDeHarry = varitaDeHarry;
            this.recetas = recetas;
        }

        public Varita VaritaDeHarry { get => varitaDeHarry;}
        public List<Receta> Recetas { get => recetas;}

        //Si esUnLento, esto ocurre cuando elige alguna de sus recetas rápidas y tarda más de 30 minutos en prepararla.
        //Si noSeCuida, esto ocurre cuando más de la mitad de sus recetas son de gordo.
        public bool esUnLento(){
            Receta recetaRapida = recetas.Any(recetaAux => recetaAux.esRapida()) ?
            recetas.Where(recetaAux => recetaAux.esRapida()).First(): null;

            return recetaRapida != null ? varitaDeHarry.tiempoParaPrepararLaReceta(recetaRapida) > 30 : 
            false;
        }
        public bool noSeCuida(){
            int recetasNoSaludables = recetas.Any(recetaAux => recetaAux.siEsDeGordo()) ?
            recetas.Where(recetaAux => recetaAux.siEsDeGordo()).ToList().Count() : 
            0;

            return recetasNoSaludables > (recetas.Count()/2);
        }
    }
}