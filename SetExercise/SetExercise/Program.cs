using SetExercise.Entities;

namespace SetExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> setA = new HashSet<Student>();
            HashSet<Student> setB = new HashSet<Student>();
            HashSet<Student> setC = new HashSet<Student>();
            

            Console.Write("How many students for the course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                setA.Add(new Student { Id = student});
            }

            Console.Write("How many students for the course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0;i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                setB.Add(new Student { Id = student});
            }

            Console.Write("How many students for the course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                setC.Add(new Student { Id = student });
            }


            HashSet<Student> all = new HashSet<Student>(setA);
            all.UnionWith(setB);
            all.UnionWith(setC);

            int totalStudents = all.Count();
            Console.Write($"Total students: {totalStudents}");
        }
    }
}