Carro c1 = new Carro("Chevrolet", "Sedan" ,"Onix" ,2016,120);


Carro c2 = new Carro("Ford","SUV","EcoSport",2018,120);


Console.WriteLine($"{c1.Modelo}, {c1.Montadora}, {c1.Marca}, {c1.Ano}, {c1.Potencia}");
c1.Acelerar();
Console.WriteLine($"{c2.Modelo}, {c2.Montadora}, {c2.Marca}, {c2.Ano}, {c2.Potencia}");
c2.Acelerar();

Console.WriteLine(c1.VelocidadeMaxima(c1.Potencia));


Console.ReadKey();
class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }

    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }
    public void Acelerar()
    {
        Console.WriteLine($"Acelerando o meu {this.Marca}");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}