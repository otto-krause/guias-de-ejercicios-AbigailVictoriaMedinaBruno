using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Ejercicio; 
namespace Testing
{
    public class Tests
    {
        PajaroComun pajaro;
        Red red;
        Bomb bomb;
        Chuck chuck;
        Terence terence;
        Matilda matilda;
        List<Pajaro> listaDePajaros;
        IslaSiniestra isla;
        Pared paredDeVidrio;
        Pared paredDeMadera;
        Cerdito cerditoObrero;
        CerditoArmado cerditoConCasco;
        List<Obstaculo> obstaculos;
        IslaCerdito isla2;
        [SetUp]
        public void Setup()
        {
            pajaro = new PajaroComun(10);
            red = new Red(20);
            bomb = new Bomb(50);
            chuck = new Chuck(30,20);
            terence = new Terence(20);
            matilda = new Matilda(20,new List<int>{10,2,3});
            listaDePajaros = new List<Pajaro>{pajaro,red,bomb,
            chuck,terence,matilda};
            isla = new IslaSiniestra(listaDePajaros);
            paredDeMadera = new Pared(10,"madera");
            paredDeVidrio = new Pared(20,"vidrio");
            cerditoObrero = new Cerdito();
            cerditoConCasco = new CerditoArmado(20);
            obstaculos = new List<Obstaculo>{paredDeMadera,paredDeVidrio,cerditoConCasco,cerditoObrero};
            isla2 = new IslaCerdito(obstaculos);
        }

        [Test]
        public void TestObtenerLaFuerzaDeRed()
        {
            Assert.AreEqual(0,red.fuerza());
        }
        [Test]
        public void TestHacerEnojarAChuck()
        {
            chuck.enojado();
            Assert.AreEqual(150,chuck.fuerza());
        }
        [Test]
        public void TestObtenerALosPajarosMasFuertes()
        {
            //3
            Assert.AreEqual(3,listaDePajaros.Where(i => i.fuerza()>50).ToList().Count());
        }
        [Test]
        public void TestFuerzaTotalDeLosPajarosFuertes()
        {
            Assert.AreEqual(325,listaDePajaros.Sum(i=>i.fuerza()));
        }
        [Test]
        public void TestEjecutarUnEventoDeLaIslaSiniestra()
        {
            isla.invasionDeCerditos(150);
            Assert.AreEqual(1,red.CantidadVecesEnojado);
        }
        [Test]
        public void TestUnPajaroDerribaUnObstaculo()
        {
            red.enojado();
            paredDeVidrio.ataque(red);
            Assert.AreEqual(true,paredDeVidrio.Derribado);
        }
        [Test]
        public void TestLaIslaPajaroAtacaALaIslaCerdito()
        {
            isla.ataqueACerditos(isla2);
            Assert.AreEqual(false,isla2.quedoLibreDeObstaculos());
        }
        [Test]
        public void TestLaIslaPajaroRecuperoSusHuevos()
        {
            isla.ataqueACerditos(isla2);
            Assert.AreEqual(false,isla2.quedoLibreDeObstaculos());
        }


    }
}