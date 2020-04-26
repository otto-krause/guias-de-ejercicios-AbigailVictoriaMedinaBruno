using System;
using System.Collections.Generic;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=1,contador=0,cantidad=0;
            List<int> numeros= new List<int>();
            while(numero!=0){
                Console.WriteLine("Ingrese un número, si desea terminarlo ingrese 0");
                numero=Int32.Parse(Console.ReadLine());
                if(numero!=0){
                    numeros.Add(numero);
                }
                if(numero>50)
                    contador++;
            }
            foreach (int item in numeros)
            {
                Console.WriteLine("Elemento: "+item);
            }
            cantidad=numeros.Count;
            Console.WriteLine("La lista tiene "+ cantidad +" elementos.");
            Console.WriteLine("Primer elemento: "+ numeros[0]+"\nUltimo elemento: "+ numeros[cantidad-1]);
            Console.WriteLine("La lista tiene "+ contador +" elemento/s mayor a 50.");
        }
    }
}
