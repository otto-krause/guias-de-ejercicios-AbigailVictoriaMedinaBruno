using System;

namespace E3
{
    class Program
    {
        static bool Par(int numero){
                return (numero%2)==0;
         }
        static bool Primo(int numero){
            int esPrimo=0,aux=0;
            for (int i = 1; i == numero; i++)
            {
                aux=numero % i;
                if(aux==0){
                    esPrimo++;
                }
            }
            return esPrimo==2;
        }
        static void Main(string[] args)
        {
            
            int numero=0;
            Console.WriteLine("Ingrese un número:");
            numero=Int32.Parse(Console.ReadLine());
            if(Primo(numero))
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");

            if(Par(numero))
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
            
        }
    }
}
