using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Acebo : Varita
    {
        public Acebo(int potencia) : base(potencia)
        {
        }

        public override int tiempoParaPrepararLaReceta(Receta receta){
            return receta.CaloriasDeIngredientes.Count() + potencia;
        }
    }
}