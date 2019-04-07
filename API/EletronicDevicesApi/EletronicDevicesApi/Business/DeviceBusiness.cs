using EletronicDevicesApi.Business.Inteface;
using EletronicDevicesApi.Dtos;
using EletronicDevicesApi.Entities;
using EletronicDevicesApi.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Business
{
    public class DeviceBusiness : IDeviceBusiness
    {
        private IDeviceRepository deviceRepository;
        private ICategoryRepository categoryRepository;

        public DeviceBusiness(IDeviceRepository _deviceRepository, ICategoryRepository _categoryRepository)
        {
            this.deviceRepository = _deviceRepository;
            this.categoryRepository = _categoryRepository;
        }

        public IEnumerable<DeviceEntity> GetAllDevices()
        {
            return deviceRepository.GetAllDevices();
        }

        public IEnumerable<CategoryEntity> GetAllCategories()
        {
            return categoryRepository.GetAllCategories();
        }

        public IEnumerable<DeviceDto> GetDevicesDtoByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentNullException("name");
            }
            return deviceRepository.GetDevicesDtoByName(name);
        }

        public IEnumerable<DeviceEntity> GetAllDevicesByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name");
            }
            return deviceRepository.GetAllDevicesByName(name);
        }
    }
}
