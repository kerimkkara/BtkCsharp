namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3] { 
            
                new Customer
                {
                    Name = "Test"
                },
                new Person
                {
                    Name= "Test1"
                }, 
                new Student
                {
                    Name = "Test2"
                }
            };

            foreach (Person p in person)
            {

                Console.WriteLine(p.Name);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //tek inheritance alabilir
    //birden fazla interface


    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {   
        public string Department { get; set; }
    }
}