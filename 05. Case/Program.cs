namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if (hour < 12)
            {
                Console.WriteLine("Good morning.");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Good afternoon.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            bool isGoldCustomer = true;
            float price;
            // if (isGoldCustomer)
            // { 
            //     price = 19.95f;
            // }
            // else
            // {
            //     price = 29.95f;
            // }

            // Ternary operator
            price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("We have a promotion");
                    break;
                default:
                    Console.WriteLine("No promotion");
                    break;
            }
        }
    }
}