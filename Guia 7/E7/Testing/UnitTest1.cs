using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        Villano gru;
        Ciudad ciudadDeGru;
        LaLuna laluna;
        Piramide piramide;
        SueroMutante suero;
        Arma rayoEncogedor;

        [SetUp]
        public void Setup()
        {
            piramide = new Piramide(10);
            laluna = new LaLuna();
            suero = new SueroMutante();
            ciudadDeGru = new Ciudad(laluna,suero,piramide,50);
            gru = new Villano();
            rayoEncogedor = new Arma("Rayo Encogedor",60);
        }

        [Test]
        public void TestMinionQueParticipoEnMásMaldades()
        {
            gru.obtenerMinion();
            gru.obtenerMinion();
            gru.congelarCiudad(ciudadDeGru);
            Assert.AreEqual(1,gru.ListaDeMinions.Max(minion=> minion.ParticipacionEnMaldades));
        }
        [Test]
        public void TestLaCiudadBajaDeTemperatura()
        {
            gru.congelarCiudad(ciudadDeGru);
            Assert.AreEqual(20,ciudadDeGru.Temperatura);
        }
        [Test]
        public void TestCuantosMinionsTieneGru()
        {
            gru.obtenerMinion();
            gru.obtenerMinion();
            Assert.AreEqual(2,gru.ListaDeMinions.Count());
        }
    }
}