using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Ejercicio; 
using NUnit.Framework;

namespace Testing
{
    public class Tests
    {
        Quirk hellFlame;
        Quirk penaMortal;
        Villano badBunny;
        Villano felicitas;
        PandillaDeVillanos pandillaDeOnce;
        Heroe Endeavor;
        [SetUp]
        public void Setup()
        {
            hellFlame = new Quirk(300,"Hell Flame",false); 
            penaMortal = new Quirk(80,"Pena Mortal",true);
            badBunny = new Villano(true, true, true, penaMortal);
            felicitas = new Villano(false, false, true, penaMortal);
            pandillaDeOnce = new PandillaDeVillanos(new List<Villano>{badBunny,felicitas});
            Endeavor = new Heroe(hellFlame);
        }

        [Test]
        public void TestElQuirkDelHeroeEsPeligroso()
        {
            Assert.AreEqual(true, Endeavor.QuirkHeroe.esPeligroso());
        }
        [Test]
        public void TestHeroeLeGanaAlVillano()
        {
            Endeavor.vencerAUnVillano(felicitas);
            Assert.AreEqual(1, Endeavor.Victorias);
        }
        [Test]
        public void TestHeroeGanaContraPandilla()
        {
            Endeavor.vencerAUnaPandillaVillano(pandillaDeOnce);
            Assert.AreEqual(2, Endeavor.Victorias);
        }
        [Test]
        public void TestQuirVillanoEsPeligroso()
        {
            Assert.AreEqual(true, penaMortal.esPeligroso());
        }
    }
}