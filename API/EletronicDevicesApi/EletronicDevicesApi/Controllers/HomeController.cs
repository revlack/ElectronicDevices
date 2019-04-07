using EletronicDevicesApi.Interfaces;
using EletronicDevicesApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Controllers
{
    public class HomeController :BaseController
    {
        [Route("")]
        [HttpGet]
        public IActionResult Home()
        {
            return new JsonResult(new ApiResponse()
            {
                Response = "System working successfully",
                Status = Status.Sucess
            });
        }

        [Route("Error")]
        [HttpGet]
        public IActionResult Error()
        {
            return new JsonResult(new ApiResponse()
            {
                Response = "An error occurred",
                Status = Status.Error
            });
        }
    }
}
