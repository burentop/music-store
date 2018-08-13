using System;
using System.Collections.Generic;

class Cd 
{
  private string _title;
  private string _artist;
  private int _price;

  public void SetTitle(string newTitle)
  {
    _title = newTitle;
  }
  public string GetTitle()
  {
    return _title;
  }

  public void SetArtist(string newArtist)
  {
    _artist = newArtist;
  }
  public string GetArtist()
  {
    return _artist;
  }

  public void SetPrice(int newPrice)
  {
    if (newPrice >= 0) {
      _price = newPrice;
    }
    else {
      Console.WriteLine("The price for this item is not valid.");
    }
  }

  public int GetPrice()
  {
    return _price;
  }

  public Cd(string albumTitle, string albumArtist, int albumPrice = 10)
  {
    _title = albumTitle;
    _artist = albumArtist;
    _price = albumPrice;
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
      Console.WriteLine(album.GetTitle());
      Console.WriteLine("By " + album.GetArtist());
      Console.WriteLine("Price: $" + album.GetPrice());
    }
  }
}