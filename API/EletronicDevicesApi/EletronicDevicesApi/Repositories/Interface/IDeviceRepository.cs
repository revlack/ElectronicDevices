using EletronicDevicesApi.Dtos;
using EletronicDevicesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Repositories.Interface
{
    public interface IDeviceRepository
    {
        IEnumerable<DeviceEntity> GetAllDevices();
        IEnumerable<DeviceEntity> GetAllDevicesByName(string name);
        IEnumerable<DeviceDto> GetDevicesDtoByName(string name);
    }
}
