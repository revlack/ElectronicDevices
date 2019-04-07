using EletronicDevicesApi.Business;
using EletronicDevicesApi.Dtos;
using EletronicDevicesApi.Entities.EntitiesDb;
using EletronicDevicesApi.Repositories.Interface;
using EletronicDevicesApi.Services;
using EletronicDevicesApi.Services.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EletronicDevicesApi.Test
{
    [TestClass]
    public class IntegratedDeviceTest
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void ArgumentNullExceptionName()
        {
            var deviceRepositoryMock = GetDeviceRepositoryMock();
            var categoryRepositoryMock = GetCategoryRepositoryMock();
            var deviceBusinnes = new DeviceBusiness(deviceRepositoryMock.Object, categoryRepositoryMock.Object);
            var service = new DeviceService(deviceBusinnes);

            service.GetDevicesDtoByName(null);
        }

        [TestMethod]
        public void TestCategories()
        {
            var deviceRepositoryMock = GetDeviceRepositoryMock();
            var categoryRepositoryMock = GetCategoryRepositoryMock();
            var deviceBusinnes = new DeviceBusiness(deviceRepositoryMock.Object, categoryRepositoryMock.Object);
            var service = new DeviceService(deviceBusinnes);

            var categories = service.GetAllCategories();

            Assert.AreEqual(2, categories.Count());
        }

        [TestMethod]
        public void TestDevicesSearch()
        {
            var deviceRepositoryMock = GetDeviceRepositoryMock();
            var categoryRepositoryMock = GetCategoryRepositoryMock();
            var deviceBusinnes = new DeviceBusiness(deviceRepositoryMock.Object, categoryRepositoryMock.Object);
            var service = new DeviceService(deviceBusinnes);

            var _result = service.GetAllDevices();
            var _result2 = service.GetDevicesDtoByName("TV");
            var _result3 = service.GetDevicesDtoByName("Laptop");
            var _result4 = service.GetDevicesByName("super");
            var _result5 = service.GetDevicesByName("later");

            Assert.IsTrue(_result.Count() > 0);
            Assert.IsTrue(_result2.Count() == 0);
            Assert.IsTrue(_result3.Count() > 0);
            Assert.IsTrue(_result5.Count() == 0);
        }



        private Mock<IDeviceRepository> GetDeviceRepositoryMock()
        {
            var deviceRepositoryMock = new Mock<IDeviceRepository>();
            deviceRepositoryMock.Setup(m => m.GetDevicesDtoByName("TV")).Returns(new List<DeviceDto>());
            deviceRepositoryMock.Setup(m => m.GetDevicesDtoByName("Laptop")).Returns(new List<DeviceDto>() {
                new DeviceDto() { Category = "Laptop" , Description = "A super laptop", DeviceId = 1, ImageUrl = "exemple", Name="H12", Price= 12.4 },
                new DeviceDto() { Category = "Laptop" , Description = "A weak laptop", DeviceId = 1, ImageUrl = "exemple", Name="D30", Price= 52.4 }

            });
            deviceRepositoryMock.Setup(m => m.GetAllDevices()).Returns(new List<DeviceEntityDb>() {
                new DeviceEntityDb() { CategoryId = 1 , Description = "A super laptop", DeviceId = 1, ImageUrl = "exemple", Name="H12", Price= 12.4 },
                new DeviceEntityDb() { CategoryId = 1 , Description = "A weak laptop", DeviceId = 1, ImageUrl = "exemple", Name="D30", Price= 52.4 }

            });
            deviceRepositoryMock.Setup(m => m.GetAllDevicesByName("super")).Returns(new List<DeviceEntityDb>() {
                new DeviceEntityDb() { CategoryId = 1 , Description = "A super laptop", DeviceId = 1, ImageUrl = "exemple", Name="H12", Price= 12.4 }
            });
            deviceRepositoryMock.Setup(m => m.GetAllDevicesByName("later")).Returns(new List<DeviceEntityDb>());
            return deviceRepositoryMock;
        }


        private Mock<ICategoryRepository> GetCategoryRepositoryMock()
        {
            var _return = new Mock<ICategoryRepository>();
            _return.Setup(m => m.GetAllCategories()).Returns(new List<CategoryEntityDb>() {
                new CategoryEntityDb() { CategoryId =1 , Description = "Laptop" },
                new CategoryEntityDb() { CategoryId =1 , Description = "Laptop" }
            });

            return _return;
        }
    }
}
