using System;
using DbConnection;

namespace simpleCrud
{
    class Program
    {

        public static void read()
        {
            string query = "SELECT * FROM users";
            var users = DbConnector.Query(query);
            foreach(var user in users)
            {
                System.Console.WriteLine(user["FirstName"] + " " + user["LastName"] + " " + user["id"]);
            }
        }

        public static void create()
        {
            System.Console.WriteLine("Enter first name");
            string FirstName = '"' + Console.ReadLine() + '"';
            System.Console.WriteLine("Enter last name");
            string LastName = '"' + Console.ReadLine() + '"';
            System.Console.WriteLine("Enter favorite number");
            string FavNumber = '"' + Console.ReadLine() + '"';
            string query = $"INSERT into users(FirstName, LastName, FavoriteNumber) VALUES({FirstName}, {LastName}, {FavNumber})";
            DbConnector.Execute(query);
        }

        public static void remove()
        {
            System.Console.WriteLine("Enter id to be deleted");
            string id = Console.ReadLine();
            string removeQuery = $"DELETE FROM users WHERE id = {id}";
            DbConnector.Execute(removeQuery);
        }











        static void Main(string[] args)
        {
            remove();
            read();
            Console.WriteLine("Hello World!");
        }
    }
}
