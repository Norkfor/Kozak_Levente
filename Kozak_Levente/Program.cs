﻿using System;
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
    static string reszlegBeker = "";
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
      Console.Write("5. feladat: Kérem egy részleg nevét: ");
      reszlegBeker = Console.ReadLine();
    }

    private static void NegyedikFeladat()
    {
      int ossz = 0;
      double osztas = 0;
      foreach (var m in munkasok)
      {
        ossz = ossz + m.berezes;
        osztas = (double)ossz / munkasok.Count / 1000;
      }
      Console.WriteLine("4. feladat: Bérek átlaga: {0} eFt", Math.Round(osztas, 1));
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine("3. feladat: Dolgozók száma: {0} fő", munkasok.Count());
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
