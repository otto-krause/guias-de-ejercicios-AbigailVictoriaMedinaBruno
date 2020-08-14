using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;
namespace Testing
{
    public class Tests
    {
        Mago HarryPostre;
        Carpe varitaCarpe;
        Receta receta1; 
        //Receta receta2;
        [SetUp]
        public void Setup()
        {
            receta1 = new Receta(3,new List<int>{400,400,400});
            varitaCarpe = new Carpe(10);
            HarryPostre = new Mago(varitaCarpe,new List<Receta>{receta1,receta1});
        }

        [Test]
        public void TestSaberSiTodasLasRecetasSonDeGordoDeHarryPostre()
        {
            Assert.AreEqual(false,HarryPostre.noSeCuida());
        }
        /*Saber si alguna receta es rápida.
        Saber si Harry es un lento.
        Saber si Harry no se cuida
        */
        [Test]
        public void TestSaberSiAlgunaRecetaEsRápida()
        {
            Assert.IsFalse(HarryPostre.Recetas.Any(recetaAux => recetaAux.esRapida()));
        }
        [Test]
        public void TestSaberSiHarryPostreEsUnLento()
        {
            Assert.AreEqual(false, HarryPostre.esUnLento());
        }
        [Test]
        public void TestSaberSiHarryPostreNoSeCuida()
        {
            Assert.AreEqual(false,HarryPostre.noSeCuida());
        }
    }
}