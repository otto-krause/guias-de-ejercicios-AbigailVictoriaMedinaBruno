using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class IslaCerdito
    {
        List<Obstaculo> obstaculos;

        public IslaCerdito(List<Obstaculo> obstaculos)
        {
            this.obstaculos = obstaculos;
        }
        public void ataqueAviar(Pajaro pajaro){
            obstaculos.ForEach(i => i.ataque(pajaro));
        }
        public bool quedoLibreDeObstaculos(){
            if(obstaculos.All(i=> i.Derribado == true))
                return true;
            
            return false;
        }

    }
}