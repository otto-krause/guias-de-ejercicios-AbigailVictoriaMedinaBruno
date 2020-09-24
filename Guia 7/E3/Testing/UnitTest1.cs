using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        Tecnologia batiPistola;
        Tecnologia batiCafe;
        CiudadGotica ciudad;
        Batman batmanWinner;
        Psicopata joker;
        Ladron ladronNormal;
        Ladron ladronGuanteBlanco;
        Ladron ladronGuanteMarron;
        Ladron robinHood;
        Extraterrestre ET;
        PandillaDeVillanos pandillaDeLosFeos;

        [SetUp]
        public void Setup()
        {
            batiCafe = new Tecnologia("BatiCafe",13,2);
            batiPistola = new Tecnologia("BatiPistola",55,10);
            batmanWinner = new Batman(new List<Tecnologia>{batiCafe,batiPistola});
            joker = new Psicopata(100);
            ladronNormal = new Ladron("Ladron");
            ladronGuanteBlanco = new Ladron("Guante Blanco");
            ladronGuanteMarron = new Ladron("Guante Marron");
            robinHood = new Ladron("Robin Hood");
            ET = new Extraterrestre(4);
            pandillaDeLosFeos = new PandillaDeVillanos(new List<Villano>{ET,ladronNormal,joker});
            ciudad = new CiudadGotica(new List<int>{55555555,11111111,22222,33333333,4444444,555,444},
            new List<Villano>{joker,ladronNormal,ladronGuanteBlanco,ladronGuanteMarron,ET});
        }
        
        [Test]
        public void TestJokerAsesinaATodos()
        {
            joker.cometerCrimen(ciudad);
            ciudad.Habitantes.ForEach(habitantesVivos => Console.WriteLine(habitantesVivos));
            Assert.AreEqual(2,ciudad.Habitantes.Count());
        }
        [Test]
        public void TestLadronBlancoRobaAUnRico()
        {
            ciudad.Habitantes.ForEach(habitantes => Console.WriteLine(habitantes+" Sin Robar"));
            ladronGuanteBlanco.cometerCrimen(ciudad);
            ciudad.Habitantes.ForEach(habitantes => Console.WriteLine(habitantes+ " Hubo un robo"));
            Assert.AreEqual(7,ciudad.Habitantes.Count());
        }
        [Test]
        public void TestAbducionDeAliens()
        {
            ET.cometerCrimen(ciudad);
            Assert.AreEqual(4,ciudad.Habitantes.Count());
        }
        [Test]
        public void TestBatmanEstaEstresado()
        {
            batmanWinner.pelearConVillanos(pandillaDeLosFeos);
            Assert.AreEqual(false,batmanWinner.estaEstresado());
        }
        [Test]
        public void TestBatmanEstaDeModa()
        {
            Assert.AreEqual(true,batmanWinner.batmanAlaModa());
        }
        [Test]
        public void TestLadronRobinHood()
        {
            ciudad.Habitantes.ForEach(habitantes => Console.WriteLine(habitantes+" Sin robar"));
            robinHood.cometerCrimen(ciudad);
            ciudad.Habitantes.ForEach(habitantes => Console.WriteLine(habitantes+" Robados y dado a los pobres"));
            Assert.AreEqual(1,robinHood.fuerza());
        }
    }
}