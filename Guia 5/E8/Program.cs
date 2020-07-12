using System;
using System.Collections.Generic;
using System.Linq;
namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9,10,3,5};
            List<int> numeros1 = new List<int>{101,23,64,23,51,101};
            List<List<int>> listaDeNumeros = new List<List<int>>{numeros,numeros1};
            Matematicas2 matematicas = new Matematicas2();
            foreach(List<int> lista in listaDeNumeros){
                Console.WriteLine("De esta lista: ");
                Console.WriteLine("\nLos numeros primos son: ");
                matematicas.primos(lista).ForEach(numero => Console.WriteLine(numero));
                
                Console.WriteLine("\nLos numeros pares son: ");
                matematicas.pares(lista).ForEach(numero => Console.WriteLine(numero));
                
                Console.WriteLine("\nLos numeros primos sin repetir: ");
                matematicas.aplanar(lista).ForEach(numero => Console.WriteLine(numero));
                
                Console.WriteLine("\nLa suma de los numeros es: "+ matematicas.suma(lista));

                Console.WriteLine("La suma de los numeros impares es: "+ matematicas.sumaDePrimos(lista));
                
                Console.WriteLine("El numero mayor es: "+ matematicas.mayor(lista));

                Console.WriteLine("El numero menos es: "+ matematicas.menor(lista));
            }
        }
    }
}