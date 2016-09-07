using Nancy;
using Parcels.Objects;
using System;

namespace Parcles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["MainPage.cshtml"];
      };
      Get["/Results"] = _ => {
        Parcel myParcel = new Parcel();
        Console.WriteLine(int.Parse(Request.Query["length"]));
        myParcel.SetnumberLength(int.Parse(Request.Query["length"]));
        myParcel.SetnumberWidth(int.Parse(Request.Query["width"]));
        myParcel.SetnumberHeight(int.Parse(Request.Query["height"]));
        myParcel.SetnumberWeight(int.Parse(Request.Query["weight"]));
        myParcel.SetnumberVolume();
        return View["PageResults.cshtml", myParcel];
      };
    }
  }
}
