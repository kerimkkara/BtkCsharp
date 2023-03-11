namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();

            int number1 = 10;
            int number2 = 20;
            var result = Add2(number1, number2);
            var result2 = Add4(out number1, number2);
            Console.WriteLine(result);
         
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2 = 20) {
            number1 = 30;
            return number1 + number2;
        }

        static int Add3( ref int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add4(out int number1, int number2)
        {
            //out > methodun içinde set edilmesi gerekiyor
            number1 = 30;
            return number1 + number2;
        }

        //overloading
        static int Multiplay(int number1, int number2)
        {

            return (number1 * number2);
        }
        static int Multiplay(int number1, int number2, int number3)
        {

            return (number1 * number2);
        }
        //params
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}