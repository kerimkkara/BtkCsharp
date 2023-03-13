namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            //PersonManager manager = new PersonManager();
            //manager.Add(new Customer { 
            //    Id = 1, FİrstName = "test", LastName = "test2", Address = "Ankara" 
            //});

            //Student student = new Student
            //{
            //    Id = 1,
            //    FİrstName = "test",
            //    LastName = "test",
            //    Departmment = "IT",
            //};
            //manager.Add(student);

        CustomerManager customerManager = new CustomerManager();
            customerManager.Add(
                new SqlServerCustomerDal()
                ); ;
            customerManager.Add(
                new OracleCustomerDal()
                );


            ICustomerDal[] customerDals = new ICustomerDal[2] {

            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            };


            foreach ( var customerDal in customerDals)
            {
                customerDal.Add();
            }



            }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FİrstName { get; set; }
        string LastName { get; set; }


    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FİrstName { get; set; }
        public  string LastName { get; set; }

        public string Address { get; set; }

    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FİrstName { get; set; }
        public string LastName { get; set; }

        public string Departmment { get; set; }

    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FİrstName { get; set; }
        public string LastName { get; set; }

        public string Departmment { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FİrstName);

        }
    }
}