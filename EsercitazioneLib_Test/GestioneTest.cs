using Microsoft.VisualStudio.TestTools.UnitTesting;
using EsercitazioneLib;
namespace EsercitazioneLib_Test
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]

        public void PercentualeDiUnNumeroTest()
        {
            double n = 10;
            double valore_aspettato = 1;
            double valore_effettivo = Gestione.PercentualeDiUnNumero(n);
            Assert.AreEqual(valore_aspettato, valore_effettivo);
        }
        [TestMethod]
        public void IncrementoTest()
        {
            double n = 10;
            double valore_aspettato = 15;
            double valore_effettivo = Gestione.Incremento(n);
            Assert.AreEqual(valore_aspettato, valore_effettivo);
        }
        [TestMethod]
        public void AreaDelQuadratoTest()
        {
            double n = 25;
            double valore_aspettato = 5;
            double valore_effettivo = Gestione.AreaQuadrato(n);
            Assert.AreEqual(valore_aspettato, valore_effettivo);
        }

        [TestMethod]
        public void SommaTest()
        {
            double a = 10;
            double b = 5;
            double valore_aspettato = 15;
            double valore_effettivo = Gestione.Somma(a, b);
            Assert.AreEqual(valore_aspettato, valore_effettivo);
        }

        [TestMethod]
        public void SottrazioneTest()
        {
            double a = 10;
            double b = 5;
            double valore_aspettato = 5;
            double valore_effettivo = Gestione.Sottrazione(a, b);
            Assert.AreEqual(valore_aspettato, valore_effettivo);
        }

        [TestMethod]
        public void MoltiplicazioneTest()
        {
            double a = 10;
            double b = 5;
            double valore_aspettato = 50;
            double valore_effettivo = Gestione.Moltiplicazione(a, b);
            Assert.AreEqual(valore_aspettato, valore_effettivo);
        }

        [TestMethod]
        public void DivisioneTest()
        {
            double a = 10;
            double b = 5;
            double valore_aspettato = 2;
            double valore_effettivo = Gestione.Divisione(a, b);
            Assert.AreEqual(valore_aspettato, valore_effettivo);
        }
    }
    }
