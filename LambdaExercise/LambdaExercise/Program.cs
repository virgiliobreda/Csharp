using LambdaExercise.Entities;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace LambdaExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "C:\Users\virgi\AppData\Local\Temp\imputt.txt"
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            List<Employee> emp = new List<Employee>();

            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] filds = sr.ReadLine().Split(',');
                string name = filds[0];
                string email = filds[1];
                double salary = double.Parse(filds[2],CultureInfo.InvariantCulture);

                emp.Add(new Employee(name, email, salary));
            }

            var emails = emp.Where(e => e.Salary > limit).OrderBy(e => e.Email).Select(e => e.Email);

            var sum = emp.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

            Console.WriteLine($"EMAIL OF PEAPLE WHOSE SALARY IS MORE THAN {limit.ToString("F2",CultureInfo.InvariantCulture)}: ");

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("SUM OF SALARY OF PEOPLE WHOSE NAME STARTS WITH 'M': " + sum);
        }
    }
}