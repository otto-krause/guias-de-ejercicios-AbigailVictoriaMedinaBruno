using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Psicopata : Villano
    {
        int inteligencia; 
        int cantidadDeAsesinatos;
        string estado;

        public Psicopata(int inteligencia)
        {
            this.inteligencia = inteligencia;
        }

        public int fuerza(){
            return inteligencia * cantidadDeAsesinatos;
        }
        public void cometerCrimen(CiudadGotica ciudad){
            cantidadDeAsesinatos += ciudad.asesinatos();
            
        }
        public int cuantosVillanosSon(){
            return 1;
        }
        public void peleaConBatman(string comoMeDejoBatman){
            estado = comoMeDejoBatman;
        }
        public bool estaProfugo(){
            return estado == "Profugo";
        }
    }
}