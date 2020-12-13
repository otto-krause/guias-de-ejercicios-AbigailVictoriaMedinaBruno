using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Terence : Pajaro
    {
        
        int cantidadVecesEnojado;
        public Terence(int ira) : base(ira)
        {
            cantidadVecesEnojado=0;
        }
        public override int fuerza(){
            var rnd = new Random();
            return cantidadVecesEnojado*ira*rnd.Next(1,999);
        }
        public override void enojado(){
            cantidadVecesEnojado++;
            ira*=2;
        }
    }
}