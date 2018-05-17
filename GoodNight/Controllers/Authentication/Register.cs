using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoodNight.Controllers
{
    [Produces("application/json")]
    [Route("getrandomstring")]
    public class Register : Controller
    {
        // GET
        public async Task<string> Index()
        {
            return await RandString(5);
        }

        async Task<string> RandString(int size)
        {
            char[] rand = new char[size];
            Random r = new Random();

            await Task.Factory.StartNew(() =>
                Parallel.For(0, size, i => { rand[i] = (char) r.Next(); })
            );

            return new string(rand);
        }
    }
}
