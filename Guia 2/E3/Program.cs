using System;
using System.Collections.Generic;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre,posicion,pais;
            int numeroDeFigurita=0,numero=1;
            Album album = new Album();

            Console.WriteLine("Bienvenido al Album del Mundial");

            while(numero!=0){
                if(album.estaCompleto()){
                    Console.WriteLine("\nEl album esta completo.");
                    numero=0;
                }
                else{
                    Console.WriteLine("\nEl album NO esta completo.");
                    Console.WriteLine("Para guardar una figurita ingrese primero el nombre:");
                    nombre=Console.ReadLine();

                    Console.WriteLine("Ingrese la posición:");
                    posicion=Console.ReadLine();

                    Console.WriteLine("Ingrese el pais:");
                    pais=Console.ReadLine();

                    Console.WriteLine("Ingrese el numero de la figurita:");
                    numeroDeFigurita=Int32.Parse(Console.ReadLine());

                    Figurita ingresada = new Figurita(nombre,posicion,pais,numeroDeFigurita);
                    
                    if(album.copia(ingresada)){
                        Console.WriteLine("Si no desea ingresar más figuritas,ingrese 0:");
                        numero=Int32.Parse(Console.ReadLine());
                    }
                    else{
                        Console.WriteLine("\nLa figurita ingresada está repetida\nPor favor verifique si no se equivoco en algún ingreso\nSi ese es el caso vuelva a ingresarlo todo de nuevo.");
                    }
                }
            }   
            Console.WriteLine("Hay "+ album.cuantosDelanteros() +" figuritas de delanteros ");
            Console.WriteLine("Hay "+ album.cuantosMediocampistas() +" figuritas de mediocampistas ");
               
        }
    }
}
