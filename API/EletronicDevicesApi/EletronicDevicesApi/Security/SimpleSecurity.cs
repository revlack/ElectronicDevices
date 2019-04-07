using EletronicDevicesApi.Interfaces;
using EletronicDevicesApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Security
{
    public class SimpleSecurityAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context) {

            StringValues result;
            var authHeader = context.HttpContext.Request.Headers.TryGetValue("Authorization", out result);

            if (authHeader && result.ToString() != "SimpleAuth") {
                context.Result = new JsonResult(new ApiResponse()
                {
                    Response = "You dont have authorization for this method",
                    Status = Status.Unauthorized
                });
            }
        }


    }
}
