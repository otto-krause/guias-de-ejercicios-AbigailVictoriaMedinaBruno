using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        Persona riley;
        Recuerdo recuerdoFeliz;
        Emocion felicidad;
        [SetUp]
        public void Setup()
        {
            riley = new Persona(new DateTime(2010, 12, 01, 05, 10, 20));
            felicidad = new Emocion("Alegría",true);
            recuerdoFeliz = new Recuerdo("Algún día parare de llorar?",felicidad);
        }

        [Test]
        public void TestCrear3recuerdos()
        {
            riley.crearRecuerdo("Los días con mi hermana, jugamos a la pelota");
            riley.crearRecuerdo("Mis amigos y yo jugando al voley");
            riley.crearRecuerdo("Mi papá y mi mamá me arropan");
            Assert.AreEqual(3,riley.ListaDeRecuerdos.Count());
        }
        [Test]
        public void TestDormir()
        {
            riley.crearRecuerdo("Los días con mi hermana, jugamos a la pelota");
            riley.crearRecuerdo("Mis amigos y yo jugando al voley");
            riley.crearRecuerdo("Mi papá y mi mamá me arropan");
            riley.dormir("arropan");
            Assert.AreEqual(3,riley.PensamientoCentral.Count());
        }
        [Test]
        public void TestAsentarUnRecuerdoRandom()
        {
            riley.crearRecuerdo("Los días con mi hermana, jugamos a la pelota");
            riley.crearRecuerdo("Mis amigos y yo jugando al voley");
            riley.crearRecuerdo("Mi papá y mi mamá me arropan");
            riley.asentarRecuerdo(recuerdoFeliz,"");
            Assert.AreEqual(1,riley.PensamientoCentral.Count());
        }
        [Test]
        public void TestCambiarDeEmocionDominante()
        {
            riley.cambiarDeEmocion();
            Assert.AreEqual(false,riley.Emociones.Where(e => e.EsDominante).ToList().First().Nombre=="Alegría");
        }
        [Test]
        public void TestVerLosPensamientosCentrales()
        {
            riley.pensamientosCentralesDificilesDeExplicar().ForEach(p=>Console.WriteLine(p.Descripcion));
            Assert.Pass();
        }
        [Test]
        public void TestVerLosRecuerdosRecientesDelDia()
        {
            riley.recuerdosRecientesDelDia().ForEach(p=>Console.WriteLine(p.Descripcion));
            Assert.Pass();
        }

    }
}