namespace Loops;
class Program
{
    static void Main(string[] args)
    {
        // For Loops
        for (int i = 0; i < 100; i++) //i+=2 , i-=2, i--
        {
            Console.WriteLine(i);
        }

        // While Loops

        int number = 20;
        while (number < 50)
        {
            Console.WriteLine(number);
            number++;
        }

        // DoWhile Loops
          
        do {
            
        Console.WriteLine(number);
        
        } while (number < 50);


        //ForEach loops

        string[] students = new string[3] { "test0", "test1", "test2" };

        foreach(var student in students){
            Console.WriteLine(student);
        }
        //foreach içerisinde veriler değiştirilemez
        Console.ReadLine();

    }
}
