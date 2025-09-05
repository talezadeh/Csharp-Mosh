namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Morteza";
            var lastName = "Talezadeh";

            var myFullName = string.Format("My full name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Ali", "Reza", "Saeed" };
            var formattedNames = string.Join(", ", names);
            System.Console.WriteLine(formattedNames);

            var myFullName2 = $"My full name is {firstName} {lastName}";
            System.Console.WriteLine(myFullName2);

            var text = @"Hi Morteza
Look into the following paths:
C:\folder1\folder2\folder3
C:\folder4\folder5\folder6";
            System.Console.WriteLine(text);

        }
    }
}