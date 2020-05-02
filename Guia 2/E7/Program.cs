using System;
using System.Collections.Generic;
namespace E7
{
    class Program
    {
        static void mostrar(Argentina buenPais)
        {
            Console.WriteLine("\nAlfajores:");
            foreach (Alfajor i in buenPais.Alfajores)
            {
                Console.WriteLine("Nombre: "+ i.Nombre +"/Precio:"+i.Precio+"/ Empresa: "+ i.Empresa);
            }
        }
        static void Main(string[] args)
        {
            Argentina buenPais= new Argentina();
            int numero=1;
            while(numero!=0){
                mostrar(buenPais);
                Console.WriteLine("¡Argentina, un país con buena gente!\nIngrese lo que pasa: ");
                Console.WriteLine("(0)No ingresar más\n(1)Baja el precio del petroleo\n(2)Millai habla en la TV\n(3)CoronaVairas");
                numero=Int32.Parse(Console.ReadLine());
                switch(numero){
                    case 1: buenPais.bajarElPrecioDelPetroleo();
                        break; 
                    case 2: buenPais.millaiHablaPorTv();
                        break;
                    case 3: buenPais.coronaVairas();
                        break;
                }
            }    
            Console.WriteLine("Estado de inflación: "+buenPais.estadoInflacion());
            if(buenPais.siDefault())
                Console.WriteLine("Argentina está en default");
            else
                Console.WriteLine("Argentina no está en default todavía");
            
        }
    }
}
