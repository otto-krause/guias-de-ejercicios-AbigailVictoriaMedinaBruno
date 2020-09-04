using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        Traje traje1;
        Traje traje2;
        Niño niño1;
        Niño niño2;
        Niño niño3;
        Abuelo abuelo1;
        Adulto_Comun adulto1;
        Adulto_Necio adulto2;
        Legion legion1;
        Legion legion2;
        LegionDeLegiones legionLegion2;
        [SetUp]
        public void Setup()
        {
            traje1 = new Traje("Winnie Poo","Tierno");
            traje2 = new Traje("SAW","Terrorifico");
            niño1 = new Niño(traje1, 12);
            niño2 = new Niño(traje2, 8);
            niño3 = new Niño(traje1,5);
            abuelo1 = new Abuelo();
            adulto1 = new Adulto_Comun();
            adulto2 = new Adulto_Necio();
            legion1 = new Legion(new List<Niño>{niño1,niño2});
            legion2 = new Legion(new List<Niño>{niño2,niño3});
            legionLegion2 = new LegionDeLegiones(new List<Legion>{legion1,legion2});
            
        }
        [Test]
        public void TestActitudDeAsustarDeNiñoEstaEntre1Y10()
        {
            Assert.AreEqual(true, niño1.Actitud >= 1 && niño1.Actitud <= 10);
        }
        [Test]
        public void TestCapacidadDeAsustarDeUnNiño()
        {
            Assert.AreEqual(120, niño2.capacidadDeAsustar());
        }
        [Test]
        public void TestParaSaberSiLegionTieneMasDeDosNiños()
        {
            Assert.AreEqual(true, legion1.ListaDeNiños.Count() >= 2);
        }
        [Test]
        public void TestDeCapacidadDeAsustarTotalDeLaLegionDeLegiones()
        {
            Assert.AreEqual(342, legionLegion2.capacidadDeAsustarTotal());
        }
        [Test]
        public void TestAsustarUnAdultoConLaLegionDeLegiones()
        {
            legionLegion2.asustarAUnAdulto(adulto1);
            Assert.AreEqual(342, legionLegion2.capacidadDeAsustarTotal());
        }


    }
}