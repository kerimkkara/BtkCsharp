using System.Globalization;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1 = "test";
            string student2 = "test2";
            string student3 = "test3";

            string[] students = new string[3];
            students[0] = "test";
            students[1] = "test2";
            students[2] = "test3";

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }



            string[,] regions = new string[5, 3]
            {

                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                { "Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
                

            };

            for(int i = 0; i <= regions.GetUpperBound(0); i++)
            {

                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }

                Console.WriteLine("**************");
            }

            
        }
    }
}