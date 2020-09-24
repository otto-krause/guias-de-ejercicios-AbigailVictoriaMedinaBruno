using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Extraterrestre : Villano
    {
        int cantidadDeExtremidades;
        int cantidadDePersonasAbducidas;
        string estado;

        public Extraterrestre(int cantidadDeExtremidades)
        {
            this.cantidadDeExtremidades = cantidadDeExtremidades;
            this.cantidadDePersonasAbducidas = 0;
        }

        public int fuerza(){
            return cantidadDePersonasAbducidas / cantidadDeExtremidades;
        }
        public void cometerCrimen(CiudadGotica ciudad){
            var random = new Random();
            int personasPorAbducir = random.Next(1,ciudad.Habitantes.Count());
            cantidadDePersonasAbducidas += ciudad.abducionExtraterrestre(personasPorAbducir);
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