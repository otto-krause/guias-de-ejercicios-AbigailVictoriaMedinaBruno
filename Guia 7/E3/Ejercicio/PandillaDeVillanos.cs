using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class PandillaDeVillanos : Villano
    {
        List<Villano> listaDeVillanos;
        string estado;

        public PandillaDeVillanos(List<Villano> listaDeVillanos)
        {
            this.listaDeVillanos = listaDeVillanos;
        }

        public int fuerza(){
            return listaDeVillanos.Sum(villano => villano.fuerza());
        }
        public void cometerCrimen(CiudadGotica ciudad){
            listaDeVillanos.ForEach(villano => villano.cometerCrimen(ciudad));
        }
        public int cuantosVillanosSon(){
            return listaDeVillanos.Count();
        }
        public void peleaConBatman(string comoMeDejoBatman){
            estado = comoMeDejoBatman;
        }
        public bool estaProfugo(){
            return estado == "Profugo";
        }
    }
}