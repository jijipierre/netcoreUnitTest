using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
  public class Calculer
  {

    public int m_PremierNumero;
    public int m_DexiemeNumero;

    public int PremierNumero { get => m_PremierNumero; set => m_PremierNumero = value; }
    public int DexiemeNumero { get => m_DexiemeNumero; set => m_DexiemeNumero = value; }

    public int Add()
    {
      return PremierNumero + DexiemeNumero;
    }

  }
}
