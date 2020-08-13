using System.Collections.Generic;
using NUnit.Framework;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        Robin robin;
        Arma BastonDeMetal;
        Arma BombaDeHumo;
        Chico_Bestia chicobestia;
        Raven raven;
        [SetUp]
        public void Setup()
        {
            BastonDeMetal = new Arma(10,15);
            BombaDeHumo = new Arma(89,14);
            robin = new Robin(new List<Arma>{BombaDeHumo,BastonDeMetal},10);
            chicobestia = new Chico_Bestia("Verde",2);
            raven = new Raven(new List<string>{"Extraño a mi Papi","Me quedé sin MANTECA",
            "Perdí a Pipo","Voy a comprar pilas para Robocop","¿Donde esta Pipo?"},2);
        }
        [Test]
        public void TestSiRavenEstaTristeComiendo4PorcionesDePizza()
        {
            raven.comerPizza();
            raven.comerPizza();
            raven.comerPizza();
            raven.comerPizza();
            Assert.AreEqual(true, raven.estaTriste());
        }
        [Test]
        public void TestDelPoderDeChicoBestiaComiendoPizza()
        {
            chicobestia.comerPizza();
            Assert.AreEqual(871, chicobestia.poder());
        }
        [Test]
        public void TestParaSaberLaFuerzaDelBastonDeMetal(){
            Assert.AreEqual(620, BastonDeMetal.fuerza());
        }
        [Test]
        public void TestSiRavenEsLaMasPoderosa(){
            chicobestia.comerPizza();
            bool esMasPoderosa = raven.poder() > chicobestia.poder() && raven.poder() > chicobestia.poder() ?
            true : false;
            Assert.AreEqual(false, esMasPoderosa);
        }
        [Test]
        public void TestQueChicoBestiaLlorePorRobocopYConocerSuTristeza()
        {
            chicobestia.llorarPorRobocop();
            Assert.AreEqual(0, chicobestia.Tristeza);
        }
        [Test]
        public void TestDelPoderDeRobinLlorando2vecesPorRobocop()
        {
            robin.llorarPorRobocop();
            robin.llorarPorRobocop();
            Assert.AreEqual(598, robin.poder());
        }
        [Test]
        public void TestRavenLloraPorRobocopYSaberSiRivenEstaTriste()
        {
            raven.llorarPorRobocop();
            Assert.AreEqual(false, raven.estaTriste());
        }
        
        
    }
}