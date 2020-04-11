using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int pesoFotos1=0,pesoFotos2=0,numero=1;
            Camara trasera = new Camara(10,32);
            pesoFotos1 = trasera.pesoTotalDeFotos(trasera.pesoPorFoto());
           
            Camara frontal = new Camara(6,20);
            pesoFotos2 = frontal.pesoTotalDeFotos(frontal.pesoPorFoto());

            Celular celular = new Celular(true,true,10,8192);
 
            while (numero>0)
            {
                Console.WriteLine("\n\n¿Que desea hacer? \n(0)Salir\n(1)Ver memoria disponible\n(2)Verificar si carga la sube o no");
                numero=Int32.Parse(Console.ReadLine());
                if(numero==1){
                    Console.WriteLine("Memoria Disponible: "+ celular.memoriaDisponible(pesoFotos1,pesoFotos2) +" MB");
                }
                if(numero==2){
                    if(celular.teCargaLaSube())
                        Console.WriteLine("El celular puede cargar la SUBE");
                    else
                        Console.WriteLine("El celular no puede cargar la SUBE");
                }
            }

        }
    }

    class Celular{
        bool NFC,bluetooth;
        int cantidadDeAplicaciones=0,memoriaDeAlmacenamiento=0;
        public Celular(bool NFC,bool bluetooth,int cantidadDeAplicaciones,int memoriaDeAlmacenamiento){
            this.NFC=NFC;
            this.bluetooth=bluetooth;
            this.cantidadDeAplicaciones=cantidadDeAplicaciones;
            this.memoriaDeAlmacenamiento=memoriaDeAlmacenamiento;
        }
        public int memoriaDisponible(int fotos1,int fotos2){
            return memoriaDeAlmacenamiento-((cantidadDeAplicaciones*70)+fotos1+fotos2);
        }
        public bool teCargaLaSube(){
            return NFC;
        }

    }

    class Camara{
        int resolucionDeMegapixeles,cantidadDeFotos;
        public Camara(int resolucionDeMegapixeles,int cantidadDeFotos){
            this.resolucionDeMegapixeles=resolucionDeMegapixeles;
            this.cantidadDeFotos=cantidadDeFotos;
        }
        public int pesoPorFoto(){
            return resolucionDeMegapixeles*3;
        }
        public int pesoTotalDeFotos(int fotos3){
            return cantidadDeFotos*fotos3;
        }
    }
}
