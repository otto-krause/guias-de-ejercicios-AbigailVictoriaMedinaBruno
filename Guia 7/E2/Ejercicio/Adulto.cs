using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public abstract class Adulto
    {
        /*Cuando un niño intenta asustar a un adulto, si lo logra, recibe de éste una cierta
         cantidad de caramelos, que guarda en su bolsa. 
         No todos los adultos son igualmente propensos a asustarse:
    ●    Los adultos comunes sólo se asustan si tienen una tolerancia menor que la capacidad de susto del niño, 
    y dan tantos caramelos como la mitad de su tolerancia. 
    La tolerancia se calcula como 10 * la cantidad de niños con más de 15 caramelos 
    que intentaron asustarlo antes.
    ●    Los abuelos simulan asustarse siempre, y entregan la mitad de los caramelos de un adulto común.
    ●    Los adultos necios nunca se asustan.
*/      protected List<int> listaDeIntentosDeSusto;

        protected Adulto()
        {
        }
    
        public abstract int susto(int bolsaNiño, int capacidadDeSusto);
    }
}