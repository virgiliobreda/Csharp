namespace ExercicioFixacaoVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("How many rooms will be rented? ");
            int rentedRooms = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rentedRooms; i++)
            {
                Console.WriteLine($"\nRent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vect[room] = new Estudante(name, email);
            }

            Console.WriteLine("\nBusy Rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                } 
            }



        }
    }
}