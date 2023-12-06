using System.IO;

namespace FileFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"put a file path here";
            string targetPath = @"put a file path here";
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}