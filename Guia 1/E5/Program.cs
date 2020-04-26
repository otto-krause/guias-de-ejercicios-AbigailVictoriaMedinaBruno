using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1=0,lado2=0,hipotenusa=0;
            Console.WriteLine("Ingrese un cateto:");
            lado1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el otro cateto:");
            lado2=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hipotenusa:");
            hipotenusa=Int32.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(hipotenusa,lado1,lado2);
            if(triangulo.esIsosceles())
                Console.WriteLine("El triangulo es isosceles");
            else
                Console.WriteLine("El triangulo NO es isosceles");

            if(triangulo.esEscaleno())
                Console.WriteLine("El triangulo es escaleno");
            else
                Console.WriteLine("El triangulo NO es escaleno");
            
            if(triangulo.esEquilatero())
                Console.WriteLine("El triangulo es equilatero");
            else
                Console.WriteLine("El triangulo NO es equilatero");

            if(triangulo.esTrianguloRectangulo())
                Console.WriteLine("El triangulo es rectangulo");
            else
                Console.WriteLine("El triangulo NO es rectangulo");
        }
    }
    class Triangulo{
        int hipotenusa=0,lado1=0,lado2=0,rectangulo=0;
        public Triangulo(int hipotenusa,int lado1,int lado2){
            this.hipotenusa=hipotenusa;
            this.lado1=lado1;
            this.lado2=lado2;
        }
        public bool esEscaleno(){
            return lado1!=lado2 && lado2!=hipotenusa && lado1!=hipotenusa;
        }
        public bool esIsosceles(){
            if(lado1==lado2)
                return true;
            if(lado2==hipotenusa)
                return true;
            if(hipotenusa==lado1)
                return true;
            return false;
        }
        public bool esEquilatero(){
            return lado1==lado2 && lado2==hipotenusa && lado1==hipotenusa;
        }
        public bool esTrianguloRectangulo(){
            rectangulo=hipotenusa*hipotenusa;
            return rectangulo==((lado1*lado1)+(lado2*lado2));
        }
    }
}
