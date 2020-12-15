using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        GestorDeArchivos gestor;
        [SetUp]
        public void Setup()
        {
            gestor = new GestorDeArchivos("tuvieja");
        }

        [Test]
        public void Test1()
        {
            gestor.crearArchivo("Spiderman");
            gestor.AgregarPeliculaArchivo("Shrek");
            gestor.mostrarTodoElArchivo();
            Assert.AreEqual();
        }
    }
}