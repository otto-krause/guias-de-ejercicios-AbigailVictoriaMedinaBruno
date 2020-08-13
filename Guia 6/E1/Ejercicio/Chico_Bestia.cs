using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Chico_Bestia : Titan
    {
        string color;
        public Chico_Bestia(string color, int tristeza){
            this.color = color;
            this.tristeza = tristeza;
        }
        public void cambiarDeColor(string color){
            this.color = color;
            tristeza += 4;
        }
        public override void comerPizza(){
            color = "Amarillo patito fluorescente de las montañas del himalaya amazónico";
            Console.WriteLine(color.Count());
        }  
        public override void llorarPorRobocop(){
            Console.WriteLine(tristeza);
            tristeza = tristeza < 8 ? 0 : -8; 
            Console.WriteLine(tristeza);
        }
        public override bool estaTriste(){
            return tristeza > 5;
        }
        public override int poder(){
            return color.Count() * 13;
        }
    }
}