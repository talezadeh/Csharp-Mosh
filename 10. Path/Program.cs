namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extention = path.Substring(dotIndex);

            Console.WriteLine("Extention: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extention: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}