using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class CiudadGotica
    {
        List<int> habitantes;
        List<Villano> villanosDeLaCiudad;

        public CiudadGotica(List<int> habitantes, List<Villano> villanosDeLaCiudad)
        {
            this.habitantes = habitantes;
            this.villanosDeLaCiudad = villanosDeLaCiudad;
        }

        public List<int> Habitantes { get => habitantes;}
        public int asesinatos(){
            var random = new Random();

            int asesinados = habitantes.Count();
            int indice;
            if(asesinados > 5){
                for(int i=0 ; i<5 ; i++){
                    indice = random.Next(0,habitantes.Count());
                    habitantes.RemoveAt(indice);
                }
                return 5;
            }else{
                habitantes.Clear();
                return asesinados;
            }
        }

        public int robos(string tipo){
            var random = new Random();
            int indice = 0;
            int robo = 0;
            int habitantesTotal = habitantes.Count()-1;
            int claseBaja = habitantes.Where(habitante => habitante < 1000000).Count();
            switch(tipo){
                case "Ladron": 
                    indice = random.Next(0,habitantesTotal);
                    robo = random.Next(1,habitantes[indice]);
                    habitantes[indice] -= robo;
                    return robo;
                case "Guante Blanco": 
                    indice = random.Next(0,habitantesTotal);
                    while(habitantes[indice]<=5000000)
                        indice = random.Next(0,habitantesTotal);
                    robo = random.Next(1,habitantes[indice]);
                    habitantes[indice] -= robo;
                    return robo;
                case "Guante Marron":
                    indice = random.Next(0,habitantesTotal);
                    while(habitantes[indice] > 5000000 && habitantes[indice] < 1000000)
                        indice = random.Next(0,habitantesTotal);
                    robo = random.Next(1,habitantes[indice]);
                    habitantes[indice] -= robo;
                    return robo;
                case "Robin Hood":
                    indice = random.Next(0,habitantesTotal);
                    while(habitantes[indice] <= 5000000)
                        indice = random.Next(0,habitantesTotal);
                    robo = random.Next(1,habitantes[indice]);
                    habitantes[indice] -= robo;
                    robo /= claseBaja;
                    for(int i = 0; i < habitantes.Count() ; i++){
                        if(habitantes[i] < 1000000)
                            habitantes[i] += robo;
                    }
                    return 0;
                default:
                    return 0;
            }
        }
        public int abducionExtraterrestre(int personasAbducidas){
            var random = new Random();
            int indice;
            int cantidadDeHabitantes;
            if(habitantes.Count() > personasAbducidas){    
                for(int i=0 ; i < personasAbducidas ; i++){
                    indice = random.Next(0 , habitantes.Count());
                    habitantes.RemoveAt(indice);
                }
                return personasAbducidas;
            }else{
                cantidadDeHabitantes = habitantes.Count();
                habitantes.Clear();
                return cantidadDeHabitantes;
            }

        }
        public bool esLujosa(){
            return habitantes.Where(habitante => habitante > 5000000).ToList().Count() > habitantes.Count()/2;
        }
        public List<int> sonLosMasTop(){
            List<int> losMasTop = habitantes.OrderBy(ciudadano => ciudadano).ToList();
            losMasTop.RemoveRange(4,losMasTop.Count());
            return losMasTop; 
        }
        public List<Villano> villanosProfugos(){
            return villanosDeLaCiudad.Where(villano => villano.estaProfugo()).ToList();
        } 

    }
}