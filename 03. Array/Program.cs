namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]); // default value is false
            System.Console.WriteLine(flags[2]); // default value is false

            var names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
