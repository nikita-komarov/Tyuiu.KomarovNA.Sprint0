using Microsoft.VisualStudio.TestTools.UnitTesting;


using Tyuiu.KomarovNA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KomarovNA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessaveValid()
        {
            var name = "Никита";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Никита", res);
        }
    }
}