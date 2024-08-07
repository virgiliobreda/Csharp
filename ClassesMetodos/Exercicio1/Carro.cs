
class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    private int ano;
    public int Cor;
    public int Ano
    {
        get { return ano; }
        set
        {
            ano = value;
            if (value > 2022)
            {
                ano = 2022;
            }
            else
            {
                ano = 2000;
            }
        }
    }
        
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia, int cor)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
        Cor = cor;
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

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }
    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }
    public int AumentarPotenciaVelocidade(ref int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }
}