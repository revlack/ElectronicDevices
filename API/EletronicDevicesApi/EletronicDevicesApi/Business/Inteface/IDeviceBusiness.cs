using EletronicDevicesApi.Dtos;
using EletronicDevicesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Business.Inteface
{
    public interface IDeviceBusiness
    {
        IEnumerable<DeviceEntity> GetAllDevices();
        IEnumerable<DeviceEntity> GetAllDevicesByName(string name);
        IEnumerable<CategoryEntity> GetAllCategories();
        IEnumerable<DeviceDto> GetDevicesDtoByName(string name);
    }
}
