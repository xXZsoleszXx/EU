using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
  class Program
  {
    
    static void MasodikFeladat() 
    {
      string[] adatok = File.ReadAllLines("EUcsatlakozas.txt");
      foreach (var i in adatok)
      {
        Console.WriteLine(i);
      }
     

     
    }
    static void Main(string[] args)
    {
      MasodikFeladat();

      Console.ReadKey();
    }
  }
}
