
namespace CSharpExercise1
{ 
    public class Program
    {
        public static void Exercise1()
        {
            Console.Write("Enter a number between 1 and 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        public static void Exercise2()
        {
            Console.Write("Enter the first number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine(string.Format("The maximum is: {0}", max));
        }

        public static void Exercise3()
        {
            Console.Write("Enter the width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
                Console.WriteLine("Landscape");
            else
                Console.WriteLine("Portrait");
        }

        public static void Exercise4()
        {
            Console.Write("Enter a speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of the car: ");
            var speed = Convert.ToInt32(Console.ReadLine());
            if (speed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }

            var demeritPoints = (speed - speedLimit) / 5;
            if (demeritPoints >= 12)
                Console.WriteLine("License Suspended");
            else
                Console.WriteLine("Demerit points: " + demeritPoints);
        }
        public static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
        }
    }
}