namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id= 1;
            customer.Name = "Test";

            Customer customer2 = new Customer
            { 
                Name= "Test",
                Id= 2,
                City= "İstanbul",
                Address = "test"

            };

            Console.WriteLine(customer2.Name);
        }

    }
}