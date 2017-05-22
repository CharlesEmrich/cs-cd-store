using System;
using System.Collections.Generic;

namespace CdStore.Objects
{
  public class Store
  {
    private List<Cd> _inventory = new List<Cd>{};
    public int GetCount()
    {
      return _inventory.Count;
    }

    public void SetInventory()
    {
      Cd ambient = new Cd();
      ambient.SetTitle("Supermodified");
      ambient.SetArtist("Amon Tobin");
      ambient.SetPrice(15.99);

      Cd dance = new Cd();
      dance.SetTitle("NowThatsWhatICallDance2019");
      dance.SetArtist("Various");
      dance.SetPrice(15.99);

      Cd wavecore = new Cd();
      wavecore.SetTitle("DeathDrop");
      wavecore.SetArtist("RuPaul");
      wavecore.SetPrice(15.99);

      _inventory = new List<Cd>() {ambient, dance, wavecore};
    }

    public List<Cd> GetInventory()
    {
      return _inventory;
    }
  }
}
