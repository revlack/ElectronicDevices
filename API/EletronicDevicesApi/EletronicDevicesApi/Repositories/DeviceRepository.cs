using Dapper;
using EletronicDevicesApi.Dtos;
using EletronicDevicesApi.Entities;
using EletronicDevicesApi.Entities.EntitiesDb;
using EletronicDevicesApi.Repositories.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Repositories
{
    public class DeviceRepository : BaseSqlEletronicDevicesRepository, IDeviceRepository
    {

        #region queries
        private readonly string QUERY_GET_ALL_DEVICES = @"SELECT [DeviceId]
                      ,[CategoryId]
                      ,[Name]
                      ,[ImageUrl]
                      ,[Price]
                      ,[Description]
                  FROM [ElectronicDevices].[dbo].[Device]";

        protected readonly string QUERY_NAME_FILTER = @" WHERE Name LIKE @name ";

        protected readonly string QUERY_GET_ALL_DEVICES_DTO = @"SELECT  DeviceId
                                          ,Category.Description AS Category
                                          ,Name
                                          ,ImageUrl
                                          ,Price
                                          ,Device.Description 
                                      FROM Device
                                      JOIN Category ON  Device.CategoryId = Category.CategoryId
                                      WHERE Device.Name LIKE @name";

        #endregion


        public DeviceRepository(IConfiguration configuration)
            : base(configuration) { }

        public IEnumerable<DeviceEntity> GetAllDevices()
        {
            return this.Query<DeviceEntityDb>(QUERY_GET_ALL_DEVICES);
        }

        public IEnumerable<DeviceEntity> GetAllDevicesByName(string name)
        {
            string query = QUERY_GET_ALL_DEVICES + QUERY_NAME_FILTER;
            return this.Query<DeviceEntityDb>(query, new { name = "%" + name + "%" });
        }

        public IEnumerable<DeviceDto> GetDevicesDtoByName(string name)
        {
            string query = QUERY_GET_ALL_DEVICES_DTO;
            return this.Query<DeviceDto>(query, new { name = "%" + name + "%" });
        }
    }
}

