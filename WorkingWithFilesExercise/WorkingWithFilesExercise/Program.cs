using System.Globalization;

namespace WorkingWithFilesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path: ");
            string path = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(path);

                string sourceFolder = Path.GetDirectoryName(path);
                string targetFolder = sourceFolder + @"\out";
                string targetFileFolder = targetFolder + @"\sumary.csv";

                Directory.CreateDirectory(targetFolder);

                using (StreamWriter sw = File.AppendText(targetFileFolder))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double value = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, value, quantity);

                        sw.WriteLine($"{product.Name}, {product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
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