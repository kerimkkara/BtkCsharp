namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();

        }
    }

    class Database
    {
        public virtual void Add() {

            Console.WriteLine("Added by default");

        }
        public virtual void Delete() { 
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        // Genel fonksiyonun değişiklik gösterdiği yerlerde virtual methodları override
        // edip değiştirebiliriz
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }

    class MySql : Database
    {

    }
}