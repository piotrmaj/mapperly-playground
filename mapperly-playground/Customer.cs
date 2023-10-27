using Riok.Mapperly.Abstractions;

namespace mapperly_playground
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class CustomerDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    [Mapper]
    public partial class CustomerMapper
    {
        public partial CustomerDto ToDto(Customer customer);
        public partial Customer ToDomain(CustomerDto dto);
    }
}
