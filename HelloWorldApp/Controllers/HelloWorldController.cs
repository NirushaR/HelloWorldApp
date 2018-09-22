using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldApp.Controllers
{
    public class HelloWorldController : ApiController
    {
        /// <summary>
        /// API to expose the String
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetHello")]
        public string Get()
        {
            return "Hello World";
        }
    }
}
