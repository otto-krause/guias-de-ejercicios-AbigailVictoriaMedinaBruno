using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Ejercicio;

namespace Testing
{
    public class Tests
    {
        QuirkNormal hellFlame;
        QuirkNormal penaMortal;
        OneForAll oneforall;
        AllForOne allforone;
        Villano OruMaito;
        Villano badBunny;
        Villano ArturoMirodilla;
        PandillaDeVillanos pandillaDeOnce;
        Heroe Endeavor;
        [SetUp]
        public void Setup()
        {
            hellFlame = new QuirkNormal("Hell Flame",false,300); 
            penaMortal = new QuirkNormal("Pena Mortal",true,80);
            oneforall = new OneForAll(60); 
            allforone = new AllForOne();
            badBunny = new Villano(true, true, true, new List<Quirk>{penaMortal});
            ArturoMirodilla = new Villano(false, false, true, new List<Quirk>{allforone});
            OruMaito = new Villano(true, true, true, new List<Quirk>{oneforall});
            pandillaDeOnce = new PandillaDeVillanos(new List<Villano>{badBunny,OruMaito});
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
            Endeavor.vencerAUnVillano(OruMaito);
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
        [Test]
        public void TestOneForAll()
        {
            ArturoMirodilla.traspasarQuirk(OruMaito);
            Assert.AreEqual(1,OruMaito.listaDeQuirk.Count());
        }
        [Test]
        public void TestAllForOne()
        {
            OruMaito.robarQuirk(badBunny);
            Assert.AreEqual(1, OruMaito.listaDeQuirk.Count());
        }
    }
}
