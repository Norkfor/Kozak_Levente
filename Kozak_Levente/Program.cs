using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kozak_Levente
{
  class Program
  {
    static List<Dolgozok> munkasok = new List<Dolgozok>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      Console.ReadKey();
    }

    private static void HetedikFeladat()
    {

    }

    private static void HatodikFeladat()
    {

    }

    private static void OtodikFeladat()
    {

    }

    private static void NegyedikFeladat()
    {

    }

    private static void HarmadikFeladat()
    {

    }

    private static void MasodikFeladat()
    {
      StreamReader be = new StreamReader("berek2020.txt");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        munkasok.Add(new Dolgozok(a[0], a[2], a[1], int.Parse(a[3]), int.Parse(a[4])));
      }
      be.Close();
    }
  }
}
