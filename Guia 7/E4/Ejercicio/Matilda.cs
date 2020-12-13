using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Matilda : Pajaro
    {
        List<int> pesoDeCadaHuevo;
        public Matilda(int ira,List<int> pesoDeCadaHuevo) : base(ira)
        {
            this.pesoDeCadaHuevo = pesoDeCadaHuevo;
        }
        public override int fuerza(){
            return ira*2 + pesoDeCadaHuevo.Sum(); 
        }
        public override void enojado(){
            pesoDeCadaHuevo.Add(2);
        }
    }
}