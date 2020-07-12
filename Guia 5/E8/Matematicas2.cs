using System;
using System.Linq;
using System.Collections.Generic;
namespace E8
{
    public class Matematicas2
    {
        public Matematicas2()
        {
        }
        public List<int> primos(List<int> numeros){
            //Primos: devuelve solo los números que son primos.
            List<int> aux = new List<int>();
            
            foreach(int numeroAux in numeros){
                int contador = 0;
                for(int j=1; j < (numeroAux+1); j++){
                    if(numeroAux % j == 0)
                        contador++;
                }
                if(contador == 2 || numeroAux == 1)
                    aux.Add(numeroAux);
            }
            return aux;
        }
        public List<int> pares (List<int> numeros){
            //Pares: devuelve solo los números que son pares.
            return numeros.Where(numeroAux => numeroAux % 2 == 0).ToList();
        }
        public List<int> aplanar(List<int> numeros){
            //Aplanar: muestra la lista sin repetidos.
            return primos(numeros).Distinct().ToList();
        }
        public int suma(List<int> numeros){
            //Suma: devuelve la sumatoria de todos los números.
            int nu = numeros.Sum();
            return nu;
        }
        public int sumaDePrimos(List<int> numeros){
            //SumaDePrimos: devuelve la sumatoria de todos los números que son primos.
            return primos(numeros).Sum();
        }
        public int mayor(List<int> numeros){
            return numeros.Max();
        }
        public int menor(List<int> numeros){
            return numeros.Min();
        }
       
    }
}