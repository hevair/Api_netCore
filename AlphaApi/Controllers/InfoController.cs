using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaApi.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {

        [HttpGet]
        public object Get()
        {

            var obj = new {
                    Name = "ApiAlpha",
                    Description = "Api Rest Using .net core with Swagger ",
                    Author = "Hevair Rodrigues",
                    _type= "studing"
                };


            return obj;
        }
    }
}
