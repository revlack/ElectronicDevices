using EletronicDevicesApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Models
{
    public class ApiResponse : IApiResponse
    {
        public Status Status { get; set; }
        public object Response { get; set; }
    }
}
