namespace UsingBlockTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\virgi\OneDrive\Área de Trabalho\projetos.net\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                    
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}