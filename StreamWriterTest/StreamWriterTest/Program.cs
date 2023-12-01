namespace StreamWriterTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\Users\virgi\OneDrive\Área de Trabalho\projetos.net\file1.txt";
            string targetPath = @"C:\Users\virgi\OneDrive\Área de Trabalho\projetos.net\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());

                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}