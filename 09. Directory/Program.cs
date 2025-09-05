namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            //var files = Directory.GetFiles(@"c:\temp\folder1", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
            //   Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\temp\folder1", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("c:\\temp\\folder1");

            var directoryInfo = new DirectoryInfo("c:\\temp\\folder1");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();    
        }
    }
}