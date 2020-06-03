using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa MonsterInc = new Empresa();
            int opcion=0;
            do{
                Console.WriteLine("\n¿Qué desea hacer la empresa?"+
                "\n(1)Noche de Sustos"+
                "\n(2)Noche de Risas"+
                "\n(3)Saber energía total"+
                "\n(4)Mostrar mounstros respetables"+
                "\nCualquier otra tecla para salir.");
                opcion = Int32.Parse(Console.ReadLine());
                switch(opcion){
                    case 1:MonsterInc.nocheDeSustos();
                        break;
                    case 2:MonsterInc.nocheDeRisas();
                        break;
                    case 3:Console.WriteLine("La energía total generada es: "+ MonsterInc.energiaGenerada());
                        break;
                    case 4:
                        foreach(Mounstro monsterAux in MonsterInc.listaDeMounstrosRespetables()){
                            Console.WriteLine(monsterAux.Nombre + "/Puntos de respeto: "+monsterAux.losPuntosDeRespeto());
                        }
                        break;
                    default: opcion = 0; break;
                }
            }while(opcion != 0);
        }
    }
}
