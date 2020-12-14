using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class OneForAll : Quirk
    {
        int vecesTraspasado;
        double traspaso;
        public OneForAll(int tiempoDeUso) : base (tiempoDeUso){
            vecesTraspasado = 0;
            traspaso = 0;
            nombre = "One For All";
            tieneConsecuencias = false;
            
        }
        public override double poder(){
            return (nombre.Length * tiempoDeUso) + traspaso;
        }
        public override bool esPeligroso(){
            return true;
        }
        public override void traspasa(){
            vecesTraspasado++;
            traspaso += (nombre.Length*tiempoDeUso)*0.15;

        }
    }
}