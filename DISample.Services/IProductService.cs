using DISample.Services.Dtos;
using System.Collections.Generic;

namespace DISample.Services
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll();
    }
}