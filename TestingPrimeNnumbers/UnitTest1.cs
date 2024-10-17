using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Week4;

namespace TestingPrimeNnumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(17,true)]
        [DataRow(31, true)]
        [DataRow(27, false)]
        [DataRow(64, false)]
        public void TestMethod1(int num, bool expected)
        {
            PrimeNumbers primeNumber = new PrimeNumbers();

            bool isPrime = primeNumber.PrimeOrNot(num);

            Assert.AreEqual(expected,isPrime);
        }
    }
}
