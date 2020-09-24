using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Batman
    {
        List<Tecnologia> batiRiñonera;
        int vitalidad;
        int estres;
        public Batman(List<Tecnologia> batiRiñonera)
        {
            this.batiRiñonera = batiRiñonera;
            this.vitalidad = 800;
            this.estres = 8;
        }

        public int fuerza(){
            int poderHerramienta = batiRiñonera.Sum(herramienta => herramienta.poderDeHerramienta());
            return vitalidad + poderHerramienta;
        }
        public void llorarPorSusPadres(){
            var random = new Random();
            estres -= 10;
            batiRiñonera.RemoveAt(random.Next(0,batiRiñonera.Count()));
        }
        public bool estaEstresado(){
            return estres > 15;
        }
        public bool batmanAlaModa(){
            return batiRiñonera.All(h => h.Nombre.StartsWith("Bati"));
        //[0] =='B' && h.Nombre[1]=='a' && h.Nombre[2]=='t' && h.Nombre[3]=='i'
        }
        public void bailarBatiTwist(){
            vitalidad += 100;
        }
        public void pelearConVillanos(Villano villanosPelear){
            batiRiñonera.ForEach(arma => arma.combatiendoCrimen());
            if(fuerza() > villanosPelear.fuerza())
                villanosPelear.peleaConBatman("Inconsciente");
            else{
                villanosPelear.peleaConBatman("Profugo");
                vitalidad = vitalidad >= 200 ? vitalidad - 200 : 0; 
            }
            estres += villanosPelear.cuantosVillanosSon();
        }
    }
}