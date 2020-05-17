using System;

namespace E3
{
    class Program
    {
        static int ingresoPrecio(){
            int precio=0;
            Console.WriteLine("Ingrese el precio del componente:");
            precio = Int32.Parse(Console.ReadLine());
            return precio;
            
        }
        static int ingresoFrecuencia(){
            int frecuencia=0;
            Console.WriteLine("Ingrese la frecuencia de la memoria RAM:");
            frecuencia = Int32.Parse(Console.ReadLine());
            return frecuencia;
            
        }
        static string ingresoConector(){
            string conector;
            Console.WriteLine("Ingrese el conector del componente(Ej: SATA 6GB):");
            conector = Console.ReadLine();
            return conector;
        }
        static string ingresoZocalo(){
            string zocalo;
            Console.WriteLine("Ingrese el nombgre del zócalo(Ej: PCI-X):");
            zocalo = Console.ReadLine();
            return zocalo;
            
        }
        static void Main(string[] args)
        {   
            int precio=0;
            int frecuencia=0;
            string conector;
            string zocalo;
            int opcion=1;
            PC pc = new PC();
            do{
                Console.WriteLine("\n¿Qué componente desea ingresar?(Debe ingresar mínimo uno de cada uno) \n"+
                "(1)Ingresar Placa De Video\n"+
                "(2)Ingresar Memoria Ram\n"+
                "(3)Ingresar Lectora de CD\n"+
                "(4)Ingresar Disco SSD\n"+
                "(5)Ingresar Disco HDD\n"+
                "Ingrese cualquier otra tecla para salir\n");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:
                        precio = ingresoPrecio();
                        zocalo = ingresoZocalo();
                        PlacaDeVideo placaDeVideo = new PlacaDeVideo(precio,zocalo);
                        pc.añadir(placaDeVideo);
                        break;
                    case 2:
                        precio = ingresoPrecio();
                        frecuencia = ingresoFrecuencia();
                        MemoriaRam memoriaRam = new MemoriaRam(precio,frecuencia);
                        pc.añadir(memoriaRam);
                        break;
                    case 3:
                        precio = ingresoPrecio();
                        conector = ingresoConector();
                        LectoraDeCD lectoraDeCD = new LectoraDeCD(precio,conector);
                        pc.añadir(lectoraDeCD);
                        break;
                    case 4:
                        precio = ingresoPrecio();
                        conector = ingresoConector();
                        DiscoSSD discoSDD = new DiscoSSD(precio,conector);
                        pc.añadir(discoSDD);
                        break;
                    case 5:
                        precio = ingresoPrecio();
                        conector = ingresoConector();
                        DiscoHDD discoHDD = new DiscoHDD(precio,conector);
                        pc.añadir(discoHDD);
                        break;
                    default:
                        opcion=0;
                        break;

                }
            }while(opcion!=0);
            
            
            do{
                Console.WriteLine("\n¿Qué desea hacer?\n(1)Ver si todos los elementos son compatibles y se puede armar.\n(2)Ver el precio total de la PC.\nIngrese cualquier otra tecla para salir");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:
                        string palabra = pc.sePuedeArmar()? "SI" : "NO";
                        Console.WriteLine("La pc "+palabra+" se puede armar.");
                        break;
                    case 2:
                        Console.WriteLine("El precio total es: "+pc.PrecioTotal());
                        break;
                    default: opcion=0; 
                        break;
                }
            }while(opcion!=0);

        }
    }
}
