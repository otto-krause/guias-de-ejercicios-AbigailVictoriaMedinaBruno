using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class SpiderTeam
    {
        List<Spiderman> integrantesDeSpiderTeam;
        Kingpin kingpin;
        public SpiderTeam(List<Spiderman> integrantesDeSpiderTeam, Kingpin kingpin)
        {
            this.integrantesDeSpiderTeam = integrantesDeSpiderTeam;
            this.kingpin = kingpin;
        }

        public void pelearConKingpPin(){
            integrantesDeSpiderTeam.ForEach(spi => spi.atacar(kingpin));
        }
        public void volverACasa(){
            //Console.WriteLine(integrantesDeSpiderTeam.Sum(spi => spi.poder()));
            List<Spiderman> ListaMenor = integrantesDeSpiderTeam.OrderBy(spi => spi.poder()).ToList(); 
            if(kingpin.fueVencido())
                integrantesDeSpiderTeam.Remove(ListaMenor.Last());
        }
        public int fuerzaDelSpiderTeam(){
            return integrantesDeSpiderTeam.Sum(spi => spi.Fuerza);
        }
    }
}