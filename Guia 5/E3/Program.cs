using System;
using System.Collections.Generic;
using System.Linq;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeDioses = new List<string>();
            List<string> signos = new List<string>();

            Armadura armadura1 = new Armadura("Flex","Bronce");
            Armadura armadura2 = new Armadura("Rayo","Oro");
            Armadura armadura3 = new Armadura("Mino","Plata");

            Caballero_Del_Zodiaco mario = new Caballero_Del_Zodiaco("Mario","Atena",armadura1,"Capricornio");
            Caballero_Del_Zodiaco martina = new Caballero_Del_Zodiaco("Martina","Zeus",armadura1,"Acuario");
            Caballero_Del_Zodiaco pablo = new Caballero_Del_Zodiaco("Pablo","Atena",armadura3,"Libra");
            Caballero_Del_Zodiaco selana = new Caballero_Del_Zodiaco("Selana","Afrodita",armadura2,"Aries");
            Caballero_Del_Zodiaco franco = new Caballero_Del_Zodiaco("Franco","Ades",armadura3,"Aries");
            
            List <Caballero_Del_Zodiaco> listaDeCaballeros = new List<Caballero_Del_Zodiaco>{mario,martina,pablo,selana,franco};
            //Mostrar todas las armaduras de los caballeros que apoyen a Atena.
            //Mostrar los nombres de todos los dioses, sin repetidos.
            //Mostrar a todos los signos del zodiaco que empiecen con la letra C.
            Console.WriteLine("\nCaballeros que apoyan a Atena:");
            listaDeCaballeros.Where(Caballero_Del_Zodiaco => Caballero_Del_Zodiaco.DiosQueApoya == "Atena").
            ToList().
            ForEach(Caballero_Del_Zodiaco => Console.WriteLine(Caballero_Del_Zodiaco.Nombre +" / Armadura: "
            + Caballero_Del_Zodiaco.Armadura.Nombre +" de "
            + Caballero_Del_Zodiaco.Armadura.Material+" / "
            + Caballero_Del_Zodiaco.DiosQueApoya));

            Console.WriteLine("\nDioses:");
            listaDeDioses = listaDeCaballeros.Select(Caballero_Del_Zodiaco => Caballero_Del_Zodiaco.DiosQueApoya).ToList();
            listaDeDioses = listaDeDioses.Distinct().ToList();
            listaDeDioses.ForEach(i => Console.WriteLine(i));
            
            Console.WriteLine("\nSignos que empiezan con C:");
            signos = listaDeCaballeros.Where(Caballero_Del_Zodiaco => Caballero_Del_Zodiaco.SignoDelZodiaco[0] == 'C').
            Select(Caballero_Del_Zodiaco => Caballero_Del_Zodiaco.SignoDelZodiaco).
            ToList();
            signos.ForEach(i => Console.WriteLine(i));
            //listaDeCaballeros.ForEach(Caballero_Del_Zodiaco => Console.WriteLine(Caballero_Del_Zodiaco.SignoDelZodiaco[0]));
        }
    }
}
