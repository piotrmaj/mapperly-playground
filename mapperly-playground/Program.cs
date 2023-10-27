namespace mapperly_playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Address = "Address 1"
            };
            var mapper = new CustomerMapper();
            var dto = mapper.ToDto(customer);
        }
    }
}