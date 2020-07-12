using System;
using System.Collections.Generic;
using System.Linq;
namespace E9
{
    class Program
    {
        /* Crear un programa que le permita al usuario ingresar tantos números 
        como desee hasta que ingrese un 0, lo que se considerará como la finalización del ingreso.
         Estos números deben ser almacenados en una lista.

            En base al programa anterior, realizar los siguientes ejercicios:

            Mostrar por pantalla todos los números.
            Mostrar cuántos números impares fueron ingresados.
            Mostrar cúal fue el primer número par.
            Mostrar los números que son mayores a 50.
            Mostrar cuántos números son mayores a 50.*/

        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int numeroIngreso = 0;
            do{
                Console.WriteLine("\n\nIngrese el numero(si desea salir ingrese 0): ");
                numeroIngreso=Int32.Parse(Console.ReadLine());
                if(numeroIngreso != 0 ){
                    numeros.Add(numeroIngreso);
                }
            }while (numeroIngreso != 0);
            Console.WriteLine("\nLos numeros ingresados son: ");
            numeros.ForEach(numero => Console.WriteLine(numero));

            Console.WriteLine("\nHay "+ numeros.Where(numero => numero % 2 != 0).
            Count()+" numeros impares.");

            Console.WriteLine("\nEl primer numero par fue: "+ 
            numeros.Where(numero => numero % 2 == 0).First());

            Console.WriteLine("\nLos numeros mayores a 50 son: ");
            numeros.Where(numero => numero > 50).ToList().ForEach(numero => Console.WriteLine(numero));

            Console.WriteLine("\nHay "+ numeros.Where(numero => numero > 50).Count() +" mayores a 50.");
        }
    }
}
