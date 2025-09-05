namespace  CsharpFunamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CsharpFunamentals\HelloWorld.cs";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //...
            }
            var content = File.ReadAllText(path);

            var fileinfo = new FileInfo(path);
            fileinfo.CopyTo("...");
            fileinfo.Delete();
            if (fileinfo.Exists)
            {
                //...
            }
        }
    }
}
