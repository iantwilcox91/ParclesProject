using Nancy;
using Parcles.Objects;

namespace Parcles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>

      {return View["_", variables];};
    }
  }
}
