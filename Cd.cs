using System;
using System.Collections.Generic;

class Cd 
{
  public string Title;
  public string Artist;
  public int Price;
}

public class Program
{
  public static void Main()
  {
    Cd firstCd = new Cd();
    firstCd.Title = "Master of Reality";
    firstCd.Artist = "Black Sabbath";
    firstCd.Price = 10;

    Cd secondCd = new Cd();
    secondCd.Title = "Electric Ladyland";
    secondCd.Artist = "Jimi Hendrix";
    secondCd.Price = 10;

    Cd thirdCd = new Cd();
    thirdCd.Title = "Nevermind";
    thirdCd.Artist = "Nirvana";
    thirdCd.Price = 10;

    List<Cd> Cds = new List<Cd>() { firstCd, secondCd, thirdCd };

    foreach (Cd album in Cds)
    {
      Console.WriteLine(album.Title);
      Console.WriteLine("By " + album.Artist);
      Console.WriteLine("Price: $" + album.Price);
    }
  }
}