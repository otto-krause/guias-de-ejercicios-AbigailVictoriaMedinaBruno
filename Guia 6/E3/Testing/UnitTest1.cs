using NUnit.Framework;
using Ejercicio;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Testing
{
    public class Tests
    {
        /*Para crear Zero, crear las siguientes armas y agregarlas a su lista:
SableDeLuz: sable que tiene 100 de potencia y fue usado 1 una vez.
BlasterGastado: es un blaster que originalmente tenia 300 de potencia y fue usado 70 veces.
Katana: sable antiguo que tiene 55 de potencia y fue usado 2 veces.
Crear un maverick llamado Roberto que tiene 20 destreza y un SableDeLuz como arma.
Crear al maverick Carlos que tiene 100 de destreza y una Katana como arma.
Crear una lista llamada mavericks con los dos mavericks creados anteriormente.

Test a realizar
Comprobar que el poder del SableDeLuz es de 200.
Comprobar que el poder del BlasterGastado es de 230.
Comprobar que el poder de la Katana es de 220.
Comprobar que el arma más poderosa de Zero (laMasPolentosa) es el BlasterGastado, y también comprobar que el poder de Zero es de 230.
Comprobar que Zero puede vencer a Roberto.
Comprobar que Zero no puede vencer a Carlos.
Correr el método de Zero llamado losPuedeVencer, utilizando la lista de mavericks. Comprobar que el resultado es falso.
*/
        Zero zero;
        Arma SableDeLuz;
        Arma BlasterGastado;
        Arma Katana;
        Maverick Roberto;
        Maverick Carlos;
        List<Maverick> mavericks;
        [SetUp]
        public void Setup()
        {
            SableDeLuz = new Sable(100,1);
            BlasterGastado = new Blaster(300,70);
            Katana = new Sable(55,2);
            zero = new Zero(new List<Arma>{SableDeLuz,BlasterGastado,Katana});
            Roberto = new Maverick(SableDeLuz,20);
            Carlos = new Maverick(Katana,100);
            mavericks = new List<Maverick>{Roberto,Carlos};
        }

        [Test]
        public void TestElPoderDelSableDeLuzEsDe200()
        {
            //Comprobar que el poder del SableDeLuz es de 200.
            Assert.AreEqual(200,SableDeLuz.poder());
        }
        [Test]
        public void TestElPoderDelBlasterGastadoEsDe230()
        {
            //Comprobar que el poder del BlasterGastado es de 230.

            Assert.AreEqual(230,BlasterGastado.poder());
        }
        [Test]
        public void TestElPoderDeLaKatanaEsDe220()
        {
            //Comprobar que el poder de la Katana es de 220.

            Assert.AreEqual(220,Katana.poder());
        }
        [Test]
        public void TestElArmaMasPoderosaDeZeroEsElBlasterGastadoYElPoderDeZeroEs230()
        {
            //Comprobar que el arma más poderosa de Zero (laMasPolentosa) es el BlasterGastado, y también comprobar que el poder de Zero es de 230.

            Assert.AreEqual(BlasterGastado,zero.laMasPolentosa());
            Assert.AreEqual(230,zero.PoderDeZero);
        }
        [Test]
        public void TestZeroPuedeVencerARoberto()
        {
            //Comprobar que Zero puede vencer a Roberto.

            Assert.AreEqual(true,zero.loPuedeVencer(Roberto));
        }
        [Test]
        public void TestZeroNoPuedeVencerACarlos()
        {
            //Comprobar que Zero no puede vencer a Carlos.

            Assert.AreEqual(false,zero.loPuedeVencer(Carlos));
        }
        [Test]
        public void TestZeroNoPuedeVencerALosMavericks()
        {
            //Correr el método de Zero llamado losPuedeVencer, utilizando la lista de mavericks. Comprobar que el resultado es falso.

            Assert.AreEqual(false,zero.losPuedeVencer(mavericks));
        }
    }
}