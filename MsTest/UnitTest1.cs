using app;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Calculer ca = new Calculer();
      ca.m_PremierNumero = 3;
      ca.m_DexiemeNumero = 3;
      Assert.AreEqual(ca.Add(), 6);
    }
  }
}
