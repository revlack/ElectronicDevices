using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Entities
{
    public abstract class DeviceEntity
    {
        public int DeviceId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

    }
}
