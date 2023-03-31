using Domain;

namespace SadWeekend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("John", "Connor");

            //Console.WriteLine(user.GetFullName()); // Compile time error. "'User' does not contain a definition for 'GetFullName'"
        }
    }
}