namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mouth = new int[3];
            mouth[0] = 1;
            mouth[1] = 2;
            mouth[2] = 3;   

            foreach (int i in mouth)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }

            string[] names = { "abel", "bryan", "castiel" };
            foreach (var item in names)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }


            int[] myArray = { 1, 2, 3, 4, 5 };
            int[] arrayTest = new int[myArray.Length * 2];
            
            


            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
                Console.WriteLine();
            }


            List<string> stringList = new List<string>();
            stringList.Add("test");
            stringList.Add("MG");
            stringList.Add("SP");
            stringList.Add("BA");
            stringList.Remove("BA");
            stringList.Sort();

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }

            PersonTest a = new PersonTest(1, "Paula");
        }
    }
}
