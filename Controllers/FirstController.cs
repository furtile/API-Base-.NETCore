using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace API_Base_.NETCore.Controllers
{
    public class FirstController
    {
        [Route("Api")]
        [HttpGet]
       public IActionResult Initi()
        {
            var teste = new
            {
                nome = "lucas"
            };
            return new JsonResult(teste);
        }
    }
}
