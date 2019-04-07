using EletronicDevicesApi.Entities;
using EletronicDevicesApi.Entities.EntitiesDb;
using EletronicDevicesApi.Repositories.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Repositories
{
    public class CategoryRepository : BaseSqlEletronicDevicesRepository, ICategoryRepository
    {
        #region queries
        private readonly string QUERY_GET_ALL_CATEGORIES = @"SELECT [CategoryId]
                                                            ,[Description]
                                                             FROM [dbo].[Category]";
        #endregion

        public CategoryRepository(IConfiguration configuration)
            : base(configuration) { }

        public IEnumerable<CategoryEntity> GetAllCategories()
        {
            return this.Query<CategoryEntityDb>(QUERY_GET_ALL_CATEGORIES);
        }
    }
}

