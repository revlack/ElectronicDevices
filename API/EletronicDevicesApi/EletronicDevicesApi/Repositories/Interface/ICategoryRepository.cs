using EletronicDevicesApi.Entities;
using System.Collections.Generic;

namespace EletronicDevicesApi.Repositories.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryEntity> GetAllCategories();
    }
}
