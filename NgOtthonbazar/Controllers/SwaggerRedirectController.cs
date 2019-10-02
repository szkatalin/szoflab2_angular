using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NgOtthonbazar.Controllers
{
    public class SwaggerRedirectController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult RedirectToSwagger() => Redirect("/swagger");
    }
}