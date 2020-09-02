using System;
using System.Collections.Generic;
//using System.Linq;
using NUnit.Framework;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        PeterParker peterparker;
        SpidermanNoir spidermannoir;
        SpiderGwen spidergwen;
        MilesMorales milesmorales;
        Kingpin kingpin;
        List<Spiderman> integrantesDeSpiderTeam;
        Traje traje1;
        Arma arma1;
        Arma arma2;
        List<Arma> arsenal;
        SpiderTeam spiderteam;
        [SetUp]
        public void Setup()
        {
            arma1 = new Arma("tuvieja",21);
            arma2 = new Arma("tuviejo",31);
            arsenal = new List<Arma>{arma1,arma2};
            
            traje1 = new Traje(15,arsenal);

            peterparker = new PeterParker(traje1,100);
            spidermannoir = new SpidermanNoir(traje1,200,peterparker);
            spidergwen = new SpiderGwen(traje1,300,8);
            milesmorales = new MilesMorales(traje1,300,30);
            kingpin = new Kingpin();
            integrantesDeSpiderTeam = new List<Spiderman>{peterparker,spidermannoir,spidergwen,milesmorales};
            spiderteam = new SpiderTeam(integrantesDeSpiderTeam,kingpin);
        }

        [Test]
        public void TestPoderDeGwenDebeSer1a10()
        {
            Assert.AreEqual(true,spidergwen.Glamour > 1 && spidergwen.Glamour < 10);
        }
        [Test]
        public void TestKingPinFueVencido()
        {
            spiderteam.pelearConKingpPin();
            spiderteam.volverACasa();
            Assert.AreEqual(true,kingpin.fueVencido());
        }
    }
}