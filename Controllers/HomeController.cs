using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

      [Route("/")]
      public ActionResult Letter()
      {
        return View();
      }
    }
}
