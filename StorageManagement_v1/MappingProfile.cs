using AutoMapper;
using StorageManagement_v1.DTOs.ProductDTO;
using StorageManagement_v1.DTOs.CustomerDTO;
using StorageManagement_v1.Models;


namespace StorageManagement_v1
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            //Customer
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CreateCustomerDTO, Customer>();
            CreateMap<UpdateCustomerDTO, Customer>();
            //Product
            CreateMap<Product, ProductDTO>();
            CreateMap<CreateProductDTO, Product>();
            CreateMap<UpdateProductDTO, Product>();

        }
    }
}
