using StorageManagement_v1.Models;

namespace StorageManagement_v1.DTOs.ProductDTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public double? Leght { get; set; }

        public double? Thickness { get; set; }

        public double? Weight { get; set; }

        public string? Materials { get; set; }

        public string? Describes { get; set; }

        public int? ProductTypeId { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }

    }

    public class CreateProductDTO
    {

        public string? Name { get; set; }

        public double? Leght { get; set; }

        public double? Thickness { get; set; }

        public double? Weight { get; set; }

        public string? Materials { get; set; }

        public string? Describes { get; set; }

        public int? ProductTypeId { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }
    }

    public class UpdateProductDTO
    {

        public string? Name { get; set; }

        public double? Leght { get; set; }

        public double? Thickness { get; set; }

        public double? Weight { get; set; }

        public string? Materials { get; set; }

        public string? Describes { get; set; }

        public int? ProductTypeId { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }
    }
}
