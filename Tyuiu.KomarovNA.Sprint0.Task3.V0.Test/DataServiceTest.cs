using System.Security.Cryptography.X509Certificates;

using Tyuiu.KomarovNA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.KomarovNA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}