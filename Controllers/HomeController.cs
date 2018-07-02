using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

      [Route("/")]
      public ActionResult Hello()
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient("Lina");
        myLetterVariable.SetSender("John");
        return View(myLetterVariable);
      }

      [Route("/journal")]
       public ActionResult Journal()
       {
         return View();
       }
    }
}
