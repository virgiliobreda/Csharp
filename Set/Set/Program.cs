using Set.Entities;
using System.Reflection.Metadata.Ecma335;

namespace Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter the file full path: ");
            string path = Console.ReadLine();   

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord {UserName = name, Instant = instant });
                    }

                    int totalUser = set.Count;
                    Console.Write($"Total User = {totalUser}");
                    Console.WriteLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}