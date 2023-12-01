namespace FileStreamStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\virgi\OneDrive\Área de Trabalho\projetos.net\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
               
            }
            catch (IOException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }

        }
    }
}