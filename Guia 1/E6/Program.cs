using System;

namespace E6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numero=1,numero1=0,numero2=0;
            while (numero>0)
            {
                Console.WriteLine("\n\n¿Que desea hacer? (0)Salir\n(1)Fibonacci\n(2)Factorial\n(3)Mayor\n(4)Menor\n(5)Cubo");
                numero=Int32.Parse(Console.ReadLine());
                if(numero==1){
                    Console.WriteLine("Ingrese un numero:");
                    numero1=Int32.Parse(Console.ReadLine()); 
                    Matematica cuenta=new Matematica(numero1,numero2);
                    cuenta.fibonacci(numero1);
                }
                if(numero==2){
                    Console.WriteLine("Ingrese un numero:");
                    numero1=Int32.Parse(Console.ReadLine()); 
                    Matematica cuenta=new Matematica(numero1,numero2);
                    
                    Console.WriteLine("El factorial es:"+ cuenta.factorial(numero1));
                }
                if(numero==3){
                    Console.WriteLine("Ingrese dos numeros:");
                    numero1=Int32.Parse(Console.ReadLine());
                    numero2=Int32.Parse(Console.ReadLine());
                    Matematica cuenta=new Matematica(numero1,numero2);
                    
                    Console.WriteLine("El mayor es:"+ cuenta.mayor(numero1,numero2));
                }
                if(numero==4){
                    Console.WriteLine("Ingrese dos numeros:");
                    numero1=Int32.Parse(Console.ReadLine());
                    numero2=Int32.Parse(Console.ReadLine());
                    Matematica cuenta=new Matematica(numero1,numero2);
                    
                    Console.WriteLine("El menor es:"+ cuenta.menor(numero1,numero2));
                }
                if(numero==5){
                    Console.WriteLine("Ingrese un numero:");
                    numero1=Int32.Parse(Console.ReadLine()); 
                    Matematica cuenta=new Matematica(numero1,numero2);
                    cuenta.cubo(numero1);
                }
            }
             
            
        }
    }
    class Matematica{
        int numero=0,numero1=0;
        public Matematica(int numero,int numero1){
            this.numero=numero;
            this.numero1=numero1;
        }
        public void fibonacci(int numero){
            int aux1=0,aux2=0,aux3=1;
            Console.WriteLine("0\n1");
            for(int i=1; i<numero+1; i++){
                aux1=aux2+aux3;
                Console.WriteLine(aux1+" ");
                aux2=aux3;
                aux3=aux1;
                
            }
        }
        public int factorial(int numero){
            int resultado=1;
            for (int i=1; i <= numero; i++)
            {
                resultado=resultado*i;
            }
            return resultado;
        }
        public int mayor(int numero ,int numero1){
            int resultado=0;
            resultado= numero>numero1 ? numero : numero1;
            return resultado;
        }
        public int menor(int numero,int numero1){
            int resultado=0;
            resultado= numero<numero1 ? numero : numero1;
            return resultado;
        }
        public void cubo(int numero){
            Console.WriteLine("El cubo del numero es:"+numero*numero*numero);

        }
    }
}
