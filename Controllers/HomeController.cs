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

       [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }
        // This did not open http://localhost:5004/greeting_card?sender=Jane&recipient=Jessica //
        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Hello", myLetterVariable);
        }
    }
}
