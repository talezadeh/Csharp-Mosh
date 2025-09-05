namespace ClassesTest
{

    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1990, 1, 1));
            Console.WriteLine($"Person's age is: {person.Age}");
        }
    }
}