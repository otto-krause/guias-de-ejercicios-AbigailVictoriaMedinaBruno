using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Niño : Malevolo
    {
        Traje traje;
        int maquillajes;
        int actitud;
        int bolsa;
        int estado;

        public Traje Traje { get => traje; }
        public int Maquillajes { get => maquillajes; }
        public int Actitud { get => actitud; }
        public int Bolsa { get => bolsa; set => bolsa = value; }

        public Niño(Traje traje, int actitud)
        {
            this.estado = 0;
            this.traje = traje;
            this.bolsa = 0;
            this.maquillajes = 3;
            this.actitud = actitud;
            if(actitud < 1 || actitud > 10){
                throw new Exception("La actitud esta fuera de rango");
            }
        }
        public int cantidadDeCaramelos(int masCaramelos){
            bolsa += masCaramelos;
            return bolsa;
        }
        public int capacidadDeAsustar(){
            return maquillajes * traje.susto() * actitud;
        }
        public void asustarAUnAdulto(Adulto adultoAux){
            if(!empachado() || estado != 2)
                bolsa += adultoAux.susto(bolsa,capacidadDeAsustar());
        }
        public void comerCaramelos(int cantidadDeCaramelos){
            if(bolsa >= cantidadDeCaramelos && cantidadDeCaramelos > 20 )
                estado = 2;
            else{
                if(bolsa >= cantidadDeCaramelos && cantidadDeCaramelos > 10)
                    estado = 1;
            }
            bolsa = bolsa < cantidadDeCaramelos ? 0 : bolsa - cantidadDeCaramelos;
        }
        public bool empachado(){
            if(estado == 1)
                actitud /= 2;
            return estado == 1;
        }
        
        
    }
}