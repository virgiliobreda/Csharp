namespace DictionaryAndSortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Paula";
            cookies["email"] = "paula@gmail.com";
            cookies["phone"] = "11111111";
            cookies["phone"] = "22222222";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);
            cookies.Remove("email");
            
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine();

            Console.WriteLine("All Cookies: ");
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in cookies) {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}