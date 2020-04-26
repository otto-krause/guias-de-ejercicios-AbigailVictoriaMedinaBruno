using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=1;
            int minutos=0;
            Gatito gatito=new Gatito("Pepe",true,45);
            while(numero>0){
                Console.WriteLine("\n¿Qué desea saber/hacer?\n(0)Si desea salir\n(1)Jugar\n(2)Comer\n(3)Esta Saluda ");
                numero=Int32.Parse(Console.ReadLine());
                if(numero==1){
                    Console.WriteLine("Ingrese cuantos minutos va a jugar:");
                    minutos=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Su gatito jugo y su energia actual es: "+ gatito.jugar(minutos));

                }else{
                    if(numero==2){
                        Console.WriteLine("Su gatito comió y su energia actual es: "+ gatito.comer());
                    }else{
                        if(numero==3){
                            if(gatito.estaSaludable())
                                Console.WriteLine("Su gatito esta saludable");
                            else
                                Console.WriteLine("Su gatito esta saludable");
                        }
                    }
                }
            }
        }

    }
    class Gatito{
        
        string nombre;
        bool vacunas;
        int energia=0;
        public Gatito(string nombre, bool vacunas, int energia){
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }  
        public int jugar(int minuto){
            energia-=2*minuto;
            return energia;
        }
        public int comer(){
            energia+=50;
            return energia;
        }
        public bool estaVacunado(){
            return vacunas;
        }
        public bool estaSaludable(){
            return vacunas && energia>30;
        }
    
    }
}
