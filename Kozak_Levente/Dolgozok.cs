using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kozak_Levente
{
  class Dolgozok
  {
    private string Nev;

    public string nev
    {
      get { return Nev; }
      set { Nev = value; }
    }

    private string Neme;

    public string neme
    {
      get { return Neme; }
      set { Neme = value; }
    }

    private string Reszleg;

    public string reszleg
    {
      get { return Reszleg; }
      set { Reszleg = value; }
    }

    private int Belepes;

    public int belepes
    {
      get { return Belepes; }
      set { Belepes = value; }
    }

    private int Berezes;


    public int berezes
    {
      get { return Berezes; }
      set { Berezes = value; }
    }

    public Dolgozok(string nev, string neme, string reszleg, int belepes, int berezes)
    {
      Nev = nev;
      Neme = neme;
      Reszleg = reszleg;
      Belepes = belepes;
      Berezes = berezes;
    }

  }
}
