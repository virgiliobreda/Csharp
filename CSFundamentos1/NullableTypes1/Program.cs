Console.WriteLine("## Nullable Types ##\n");

int? b = null;
if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}


Console.ReadKey();