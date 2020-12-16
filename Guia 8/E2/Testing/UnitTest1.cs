using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }
        [Test]
        public void TestActitudDeAsustarDeNiñoEstaEntre1Y10()
        {
            Assert.AreEqual(true, niño1.Actitud >= 1 && niño1.Actitud <= 10);
        }
    }
}