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
        Legion legionLegion2;
        Barrios barrioNorte;
        [SetUp]
        public void Setup()
        {
            traje1 = new Traje("Winnie Poo","Tierno");
            traje2 = new Traje("SAW","Terrorifico");
            niño1 = new Niño(traje1, 10);
            niño2 = new Niño(traje2, 8);
            niño3 = new Niño(traje1,5);
            abuelo1 = new Abuelo();
            adulto1 = new Adulto_Comun();
            adulto2 = new Adulto_Necio();
            legion1 = new Legion(new List<Malevolo>{niño1,niño2});
            legion2 = new Legion(new List<Malevolo>{niño2,niño3});
            legionLegion2 = new Legion(new List<Malevolo>{legion1,legion2});
            barrioNorte = new Barrios(new List<Niño>{niño1,niño2,niño3});
            
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
            Assert.AreEqual(true, legion1.ListaDeMalevolos.Count() >= 2);
        }
        [Test]
        public void TestDeCapacidadDeAsustarTotalDeLaLegionDeLegiones()
        {
            Assert.AreEqual(330, legionLegion2.capacidadDeAsustar());
        }
        [Test]
        public void TestAsustarUnAdultoConLaLegionDeLegiones()
        {
            legionLegion2.asustarAUnAdulto(abuelo1);
            Assert.AreEqual(0, legionLegion2.BolsaDeLegion);
        }
        [Test]
        public void TestParaSaberLosTresNiñosQueMasCaramelosTienen()
        {
            barrioNorte.tresNiñosQueMasCaramelosTienen().
            ForEach(nene => Console.WriteLine(nene.Actitud +" "+ nene.Bolsa));
            Assert.AreEqual(2, barrioNorte.tresNiñosQueMasCaramelosTienen().Count());
        }
        [Test]
        public void TestParaSaberCuantosTrajesHayDeNiñosConMasDe10Caramelos()
        {
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);  
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);       
            Console.WriteLine(niño1.cantidadDeCaramelos(0));   
            barrioNorte.trajesUsadosPorNiñosConMasDe10Caramelos().
            ForEach(traje => Console.WriteLine(traje.Nombre +" "+ traje.QueEs));
            Assert.AreEqual(1, barrioNorte.trajesUsadosPorNiñosConMasDe10Caramelos().Count());
        }
        [Test]
        public void TestParaSaberSiUnNiñoTieneIndigestion()
        {
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);
            niño1.asustarAUnAdulto(abuelo1);
            Console.WriteLine(niño1.cantidadDeCaramelos(0));  
            niño1.comerCaramelos(12);
            Assert.AreEqual(true, niño1.empachado());
        }


    }
}