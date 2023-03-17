using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {



            HandleException(() => { find(); });

            string[] students2 = new string[3] {

            "Test","Test2","Test3"
            };

            try
            {
                students2[3] = "Test4";
            } catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();


            void find()
            {
                List<string> students = new List<string>() { "Test", "Test2", "Test3" };

                if (!students.Contains("Ahmet"))
                {
                    throw new RecordNotFoundException("Record not found");
                }
                else
                {
                    Console.WriteLine("Record Found");
                }

            }
        }

        private static void HandleException(Action value)
        {

            try { value();
            } catch(Exception e) { 
                Console.WriteLine(e.Message); }

        }
    }
}
