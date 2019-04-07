using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Entities
{
    public abstract class CategoryEntity
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
