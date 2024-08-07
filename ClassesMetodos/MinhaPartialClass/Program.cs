using _22MinhaPartialClass;

Console.WriteLine("Partial Class");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

var data1 = DateTime.Now;
var data2 = new DateTime(2003, 07, 22);

var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");