﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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



            Product product = new Product {Id = 1, Name = "Laptop"};
            Product product2 = new Product { Id = 2, Name = "Telefon" };


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product"); 
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();
            Manager manager1 = new Manager();
            manager1.DoSomething2();
            Console.ReadLine();
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

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }


    class PersonManager : BaseClass
    {
        public PersonManager(String entity):base(entity)
        {

            
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
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

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            
        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }


    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
