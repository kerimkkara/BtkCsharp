namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract sınıflar newlenmez

            Database database = new Oracle();
            database.Add();

            Database database1 = new SqlsServer();
            database1.Add();


            
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlsServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql ");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle ");

        }
    }
}