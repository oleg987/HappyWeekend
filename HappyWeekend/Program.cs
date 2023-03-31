using Domain;

namespace HappyWeekend
{
    /// <summary>
    /// Method GetFullName() returns string.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("John", "Connor");

            //Console.WriteLine(user.GetFullName()); // Console output: "John Connor".
        }
    }
}