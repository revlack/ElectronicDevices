using EletronicDevicesApi.Business.Inteface;
using EletronicDevicesApi.Dtos;
using EletronicDevicesApi.Entities;
using EletronicDevicesApi.Repositories.Interface;
using EletronicDevicesApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Services
{
    public class DeviceService : IDeviceService
    {
        private IDeviceBusiness deviceBusiness;

        public DeviceService(IDeviceBusiness deviceBusiness) {
            this.deviceBusiness = deviceBusiness;
        }
        public IEnumerable<DeviceEntity> GetAllDevices()
        {
           return deviceBusiness.GetAllDevices();
        }
        public IEnumerable<CategoryEntity> GetAllCategories()
        {
            return deviceBusiness.GetAllCategories();
        }
        public IEnumerable<DeviceEntity> GetDevicesByName(string name)
        {
            return deviceBusiness.GetAllDevicesByName(name);
        }

        public IEnumerable<DeviceDto> GetDevicesDtoByName(string name)
        {
            return deviceBusiness.GetDevicesDtoByName(name);
        }

    }
}
