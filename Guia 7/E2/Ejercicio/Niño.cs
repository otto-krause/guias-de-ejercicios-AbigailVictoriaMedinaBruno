using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    /*Para obtener caramelos, los niños intentarán asustar a los adultos.
La capacidad de asustar de un niño se calcula como la sumatoria del susto que generan los elementos que tenga puestos
 (trajes y maquillajes, por ahora) multiplicado por la actitud del niño (un índice de 1 a 10):
●   Todos los maquillajes asustan lo mismo (actualmente 3, pero puede cambiar en un futuro).
●    El traje asusta según sea el personaje que represente:
                       ○ Tiernos: trajes como Winnie Pooh o Sullivan asustan 2
                       ○ Terroríficos: trajes como Jason o George Bush asustan 5
Cuando un niño intenta asustar a un adulto, si lo logra, recibe de éste una cierta cantidad de caramelos,
 que guarda en su bolsa. No todos los adultos son igualmente propensos a asustarse:
*/
    public class Niño
    {
        Traje traje;
        int maquillajes;
        int actitud;
        int bolsa;

        public Traje Traje { get => traje; }
        public int Maquillajes { get => maquillajes; }
        public int Actitud { get => actitud; }
        public int Bolsa { get => bolsa; set => bolsa = value; }

        public Niño(Traje traje, int actitud)
        {
            this.traje = traje;
            this.actitud = actitud;
            this.bolsa = 0;
            this.maquillajes = 3;
        }
        public int capacidadDeAsustar(){
            return maquillajes * traje.susto() * actitud;
        }
        public void asustarAUnAdulto(Adulto adultoAux){
            bolsa += adultoAux.susto(bolsa,capacidadDeAsustar());
        }
        public void comerCaramelos(int cantidadDeCaramelos){
            bolsa = bolsa < cantidadDeCaramelos ? 0 : bolsa - cantidadDeCaramelos;
        }
        
        
    }
}