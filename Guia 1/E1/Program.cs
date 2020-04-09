using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector=new int[10];
            int suma=0,promedio=0,aux=0;
            for(int i=0;i<10;i++){
                Console.WriteLine("Ingrese un número:");
                vector[i]=Int32.Parse(Console.ReadLine());
                suma+=vector[i];

            }
            for(int i=1; i<10; i++)
            {
                for(int j=0; j<10-i; j++)
                {
                    if(vector[j]<vector[j+1])
                    {
                        aux    = vector[j+1];
                        vector[j+1] = vector[j];
                        vector[j]   = aux;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
              Console.WriteLine("El vector en descendiente: "+ vector[i]); 
            }
            promedio=suma/10;
            Console.WriteLine("La suma de los números son: "+ suma +"\nEl número menor: "+ vector[9] +"\nEl promedio es:"+ promedio);
        }
    }
}
