using Microsoft.AspNetCore.Mvc;
using System;

namespace ProductivityTools.EchoApi
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : Controller
    {
        [HttpGet]
        [Route("Date")]
        public string Date()
        {
            return DateTime.Now.ToString();
        }

        [HttpPost]
        [Route("Hello")]
        public string Hello(object s)
        {
            return string.Concat($"Hello {s.ToString()} Current date:{DateTime.Now}");
        }
    }
}
