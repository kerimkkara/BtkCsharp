using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager(10);

            manager.List();

            Console.ReadLine();


            Product product = new Product {Id = 1, Name = "Laptop"};
            Product product2 = new Product { Id = 2, Name = "Telefon" };


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

        }
    }

    class CustomerManager {

        private int _count = 15;
        public CustomerManager(int count) {

            _count = count;
        }

        public CustomerManager()
        {
            
        }

        public void List(){

            Console.WriteLine("Listed {0} items",_count);
            }

        public void Add()
        {
            Console.WriteLine("Added");
        }
      }



    class Product
    {
        public Product()
        {
            
        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }


    interface ILogger
    {
        void Log();
    }


    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }


    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added {0}", _logger);
        }
    }
}
