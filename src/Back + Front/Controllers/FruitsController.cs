using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoodNight.Controllers
{
    [Produces("application/json")]
    [Route("api/Fruits")]
    public class FruitsController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return new List<string>()
            {
                "Apple",
                "Orange",
                "Banana"
            };
        }
    }
}