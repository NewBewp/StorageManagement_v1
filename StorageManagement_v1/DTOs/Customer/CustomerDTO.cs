namespace StorageManagement_v1.DTOs.CustomerDTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }
    }

    public class CreateCustomerDTO
    {
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }
    }

    public class UpdateCustomerDTO
    {   
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }
    }
}
