using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

   

            //ArrayList cities = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Adana");

            //cities.Add(1);
            //cities.Add('A');

            //foreach(var city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            //cities.Add("İstanbul");

            List<string> cities = new List<string>();

            cities.Add("Ankara");
            cities.Add("İstanbul");
           
            foreach (string city in cities) { 
                
                Console.WriteLine(city);
            }

            List<customer> customers = new List<customer>();

            customers.Add(new customer { Id = 1, Name = "Test"});
            customers.Add(new customer { Id = 1, Name = "Test2" });

            var count = customers.Count; // sayı

            var customer2 = new customer { Id = 5 , Name = "Test5" };
            customers.AddRange(new customer[2] { 
            
                new customer { Id = 3, Name= "Test3" },
                new customer { Id = 4,Name = "Test4" },
            });

            //customers.Clear(); 

            Console.WriteLine(cities.Contains("Ankara")); // varsa true döner

            var index = customers.IndexOf(customer2); // elemanın listede kaçıncı sırada olduğunu verir

            Console.WriteLine($"Index : {0}", index);

            customers.LastIndexOf(customer2); // aramaya sondan başlar

            customers.Insert(0, customer2); // kaçıncı sıraya eklenecek

            customers.Remove(customer2); // bulduğu ilk değeri siler ve durur
            customers.RemoveAll(c=>c.Name == "Salih");



            foreach(var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }


            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            dictionary.ContainsKey("Table");

        }
    }

    class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
