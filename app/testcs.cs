using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace app
{
  public class testcs
  {
    [Fact]
    public void Test1()
    {
      Calculer ca = new Calculer();
      ca.m_PremierNumero = 3;
      ca.m_DexiemeNumero = 3;
      Assert.Equal(ca.Add(), 6);
    }
  }
}
