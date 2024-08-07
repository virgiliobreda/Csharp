Carro c1 = new Carro("Chevrolet", "Sedan" ,"Onix" ,2016,120, 1);


Carro c2 = new Carro("Ford","SUV","EcoSport",2018,120, 3);


Console.WriteLine($"{c1.Modelo}, {c1.Montadora}, {c1.Marca}, {c1.Ano}, {c1.Potencia}");
c1.Acelerar();
Console.WriteLine($"{c2.Modelo}, {c2.Montadora}, {c2.Marca}, {c2.Ano}, {c2.Potencia}");
c2.Acelerar();

Console.WriteLine(c1.VelocidadeMaxima(c1.Potencia));

Console.WriteLine("Aumentando potencia");
Console.WriteLine(c1.AumentarPotencia(c1.Potencia));
Console.WriteLine(c1.Potencia);

Console.WriteLine("Aumentando potencia referencia ref");
Console.WriteLine(c1.AumentarPotencia(ref c1.Potencia));
Console.WriteLine(c1.Potencia);

Console.WriteLine("Aumentando potencia referencia out");
c1.AumentarPotenciaVelocidade(ref c1.Potencia, out double velocidade);
Console.WriteLine(c1.Potencia);
Console.WriteLine(velocidade);


Console.ReadKey();
