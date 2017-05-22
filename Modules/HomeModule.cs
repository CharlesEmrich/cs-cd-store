using System;
using Nancy;
using CdStore.Objects;

namespace CdStore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Store myStore = new Store();
        // myStore.SetInventory();
        return View["index.cshtml", myStore];
      };


    }
  }
}
