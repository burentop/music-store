using System;
using System.Collections.Generic;

class Cd 
{
  public string Title;
  public string Artist;
  public int Price;

  public Cd(string albumTitle, string albumArtist, int albumPrice = 10)
  {
    Title = albumTitle;
    Artist = albumArtist;
    Price = albumPrice;
  }
}

public class Program
{
  public static void Main()
  {
    Cd firstCd = new Cd("Master of Reality", "Black Sabbath");
    Cd secondCd = new Cd("Electric Ladyland", "Jimi Hendrix");
    Cd thirdCd = new Cd("Nevermind", "Nirvana");
    Cd fourthCd = new Cd("I Don't Get It", "Pork Loin", 50);

    List<Cd> Cds = new List<Cd>() { firstCd, secondCd, thirdCd, fourthCd };

    foreach (Cd album in Cds)
    {
      Console.WriteLine(album.Title);
      Console.WriteLine("By " + album.Artist);
      Console.WriteLine("Price: $" + album.Price);
    }
  }
}