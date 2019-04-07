using EletronicDevicesApi.Dtos;
using EletronicDevicesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Services.Interface
{
    public interface IDeviceService
    {
        IEnumerable<DeviceEntity> GetAllDevices();
        IEnumerable<DeviceEntity> GetDevicesByName(string name);
        IEnumerable<CategoryEntity> GetAllCategories();
        IEnumerable<DeviceDto> GetDevicesDtoByName(string name);
    }
}
