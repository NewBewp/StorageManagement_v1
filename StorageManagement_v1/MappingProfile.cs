using AutoMapper;
using StorageManagement_v1.DTOs.ProductDTO;
using StorageManagement_v1.Models;

namespace StorageManagement_v1
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Product, ProductDTO>();
            CreateMap<CreateProductDTO, Product>();
        }
    }
}
