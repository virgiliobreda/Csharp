namespace DirectoryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\virgi\AppData\Local\Temp\myFolder";


            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");

                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}