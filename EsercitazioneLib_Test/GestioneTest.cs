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
    }
}
