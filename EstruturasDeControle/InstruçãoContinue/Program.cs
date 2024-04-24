Console.WriteLine();

for (var i = 0; i < 10; i++)
{   
    if (i == 0 || i == 9 || i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}