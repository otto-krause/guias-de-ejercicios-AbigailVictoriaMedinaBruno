using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1=0,numero2=0,divisor=0,dividendo=0,cociente=0,resto=0,producto=0;

            Console.WriteLine("Ingrese dos números para multiplicar:");
            numero1=Int32.Parse(Console.ReadLine());
            numero2=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un dividendo y un divisor:");
            dividendo=Int32.Parse(Console.ReadLine());
            divisor=Int32.Parse(Console.ReadLine());
            while(dividendo==0 && divisor==0){
                Console.WriteLine("Ingrese un dividendo y un divisor(distinto de 0):");
                dividendo=Int32.Parse(Console.ReadLine());
                divisor=Int32.Parse(Console.ReadLine());
            }

            for(int i=0; i<numero2; i++){
                producto+=numero1;
            }
            Console.WriteLine("El producto de "+ numero1 +" * "+ numero2+" es "+ producto);
            resto = dividendo;

            while ( resto >= divisor )
            {
                resto -= divisor;
                cociente++;
            }

            Console.WriteLine(dividendo + " dividido "+ divisor);
            Console.WriteLine("Cociente:"+ cociente +"\nResto:"+ resto);

        }
    }
}
