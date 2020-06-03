using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abigail
           //Polimorfismo
            //Definicion pura: muchos objestos entienden los mismos mensajes

            //Pedro, Ana
            //Pedro.come()
            //Ana.come()

            //Lenguajes tipados vs no tipados
            //var algo = 3;
            //var algo2 = "cadena";

            //int algo =3;
            //string algo2 = "cadena";

            //Instanciar: crear un objeto
            //Instancia: un objeto creado a partir de una clase

            //Gatito silvestre = new Gatito();
            //Gatito garfield = new Gatito();

            //silvestre y garfield son polimorficos por pertenecer a la misma clase

            //Planta, Homero, Lenny, PatoBalancin, MrBurns

            //Cuando hay polimorfismo en lenguajes tipados:
            //Objetos que pertenezcan a la misma clase'
            //Objetos que comparte una interfaz en comun
            //Cuando herencia

            Homero homero = new Homero(2);
            Lenny lenny = new Lenny();
            PatoBalancin pato = new PatoBalancin();
            MrBurns burns = new MrBurns();

            Planta planta = new Planta(999, homero, burns);

            string opcion = "";
            do
            {
                Console.WriteLine(
                "\n1)Ver si la planta esta en peligro\n" +
                "2)Homero come dona\n" +
                "3)Homero compra donas\n" +
                "4)Lenny toma cerveza\n" +
                "5)Cambiar empleado por Homero\n" +
                "6)Cambiar empleado por Lenny\n" +
                "7)Cambiar empleado por el Pato\n" +
                "8)Despojar a burns de sus riquezas\n"+
                "9)Llega Cargamento de Uranio");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        string palabra=planta.estaEnPeligro()?"SÍ":"NO";
                        Console.WriteLine("La planta "+palabra+" está en peligo.");
                        break;
                    case "2":
                        homero.comer();
                        break;
                    case "3":
                        homero.comprar();
                        break;
                    case "4":
                        lenny.tomarCerverza();
                        break;
                    case "5":
                        planta.CambiarEmpleado(homero);
                        break;
                    case "6":
                        planta.CambiarEmpleado(lenny);
                        break;
                    case "7":
                        planta.CambiarEmpleado(pato);
                        break;
                    case "8":
                        burns.despojarDeSusRiquezas();
                        break;
                    case "9":
                        Console.WriteLine("Ingrese cuanto Uranio llegó");
                        int uranio=Int32.Parse(Console.ReadLine());
                        planta.llegaCargamento(uranio);
                        break;    
                    default:
                        opcion = "salir";
                        break;
                }
            }
            while (opcion != "salir");
        }
    }
}
