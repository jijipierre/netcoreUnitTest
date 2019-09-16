using app;
using System;
using Xunit;

namespace XUnitTestProject1
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      Calculer ca = new Calculer();
      ca.m_PremierNumero = 3;
      ca.m_DexiemeNumero = 3;
      Assert.Equal(ca.Add(),6);
    }
  }
}
