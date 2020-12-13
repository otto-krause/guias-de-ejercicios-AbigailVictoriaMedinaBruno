using System;
using System.Linq;
using System.Collections.Generic;
namespace Ejercicio
{
    public class IslaSiniestra
    {
        List<Pajaro> pajarosDeLaIsla;

        public IslaSiniestra(List<Pajaro> pajarosDeLaIsla)
        {
            this.pajarosDeLaIsla = pajarosDeLaIsla;
        }
        public void sesionDeManejoDeIra(){
            pajarosDeLaIsla.ForEach(i=>i.terapiaGrupal());
        }
        public void invasionDeCerditos(int cantidadDeCerditos){
            if(cantidadDeCerditos>=100){
                int enojos=cantidadDeCerditos/100;
                for(int i=0;i<enojos;i++){
                    pajarosDeLaIsla.ForEach(pajaro => pajaro.enojado());
                }
            }
        }
        //public void fiestaSorpresa(){} Homenajeados??
        public void serieDeEventosDesafortunados(){
            var rnd = new Random();
            sesionDeManejoDeIra();
            invasionDeCerditos(rnd.Next(1,999));
        }
        public void ataqueACerditos(IslaCerdito islaDeCerdos){
            pajarosDeLaIsla.ForEach(pajaro => islaDeCerdos.ataqueAviar(pajaro));
        }
        
    }
}