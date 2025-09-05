namespace Indexers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mori";
            Console.WriteLine(cookie["name"]);
        }
    }
}
