namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            String compXY = x > y ? "Maior" : x < y ? "Menor" : "Igual";

            Console.WriteLine(compXY);
        }
    }
}
