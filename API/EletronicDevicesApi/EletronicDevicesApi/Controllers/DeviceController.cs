using EletronicDevicesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EletronicDevicesApi.Interfaces;
using EletronicDevicesApi.Security;
using Microsoft.AspNetCore.Authorization;
using EletronicDevicesApi.Services.Interface;

namespace EletronicDevicesApi.Controllers
{
    public class DeviceController : BaseController
    {
        private IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [Route("device/getall")]
        [HttpGet]
        [SimpleSecurityAttribute]
        public IActionResult GetAll()
        {
            try
            {
                var result = _deviceService.GetAllDevices();
                return new JsonResult(new ApiResponse()
                {
                    Response = result,
                    Status = Status.Sucess
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new ApiResponse()
                {
                    Response = e.Message,
                    Status = Status.Error
                });
            }
        }


        [Route("category/getall")]
        [HttpGet]
        [SimpleSecurityAttribute]
        public IActionResult GetAllCategories()
        {
            try
            {
                var result = _deviceService.GetAllCategories();
                return new JsonResult(new ApiResponse()
                {
                    Response = result,
                    Status = Status.Sucess
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new ApiResponse()
                {
                    Response = e.Message,
                    Status = Status.Error
                });
            }
        }

        [Route("device/getbyname")]
        [HttpGet]
        [SimpleSecurityAttribute]
        public IActionResult GetByName(string name)
        {
            try
            {
                var result = _deviceService.GetDevicesByName(name);
                return new JsonResult(new ApiResponse()
                {
                    Response = result,
                    Status = Status.Sucess
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new ApiResponse()
                {
                    Response = e.Message,
                    Status = Status.Error
                });
            }
        }


        [Route("site/device/getbyname")]
        [HttpGet]
        [SimpleSecurityAttribute]
        public IActionResult GetDtoByName(string name)
        {
            try
            {
                var result = _deviceService.GetDevicesDtoByName(name);
                return new JsonResult(new ApiResponse()
                {
                    Response = result,
                    Status = Status.Sucess
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new ApiResponse()
                {
                    Response = e.Message,
                    Status = Status.Error
                });
            }
        }
    }
}
