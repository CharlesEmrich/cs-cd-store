using System;

namespace CdStore.Objects
{
  public class Cd
  {
    private string _title;
    private string _artist;
    private double _price;

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetArtist()
    {
      return _artist;
    }

    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }

    public double GetPrice()
    {
      return _price;
    }

    public void SetPrice(double newPrice)
    {
      _price = newPrice;
    }
  }
}
