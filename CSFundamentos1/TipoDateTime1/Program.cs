Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
//criando uma data especifica 
DateTime dataHoje = new DateTime(2024,04,07);
Console.WriteLine(dataHoje);

//definir as horas
DateTime dataHoraHoje = new DateTime(2024, 04, 07, 18, 51, 30);
Console.WriteLine(dataHoraHoje);

Console.ReadKey();
