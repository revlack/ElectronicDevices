using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Dtos
{
    public class DeviceDto
    {
        public int DeviceId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
