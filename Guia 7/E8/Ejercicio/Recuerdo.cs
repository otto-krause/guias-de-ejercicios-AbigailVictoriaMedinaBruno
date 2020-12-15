using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Recuerdo
    {
        string descripcion;
        Emocion emocionDominanteMomento;
        public DateTime fechaActual;
        bool esCentral;

        public Emocion EmocionDominanteMomento{get => emocionDominanteMomento;}
        public string Descripcion{get => descripcion;}
        public DateTime FechaActual{get => fechaActual;}
        public bool EsCentral{get => esCentral;}
        public Recuerdo(string descripcion,Emocion emocionDominanteMomento)
        {
            this.descripcion = descripcion;
            this.emocionDominanteMomento = emocionDominanteMomento;
            fechaActual = DateTime.Today;
        }
        public void recuerdoSeHaceCentral(){
            esCentral=true;
        }
        
    }
}