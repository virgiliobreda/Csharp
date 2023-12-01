using System.IO;

namespace FileFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\virgi\OneDrive\Área de Trabalho\projetos.net\file1.txt";
            string targetPath = @"C:\Users\virgi\OneDrive\Área de Trabalho\projetos.net\file2.txt";
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