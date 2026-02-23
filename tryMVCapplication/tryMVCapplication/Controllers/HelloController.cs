using Microsoft.AspNetCore.Mvc;

namespace tryMVCapplication.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "I tried saying hi and you ignored me";
        }

        public string Babe()
        {
            return "Just allow me talk to you Babe";
        }

    }
}
