﻿Console.WriteLine("Campos Estáticos");


ContaCorrente.Juros = 4.25f;

ContaCorrente c1 = new ContaCorrente();
c1.Conta = 101;
c1.Nome = "Maria";
//c1.Juros = 3.99f;

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 102;
c2.Nome = "Marta";
//c2.Juros = 4.99f;

Console.WriteLine($"Cliente: {c1.Nome} - Juros Anual {c1.JurosAnual()}");
Console.WriteLine($"Cliente: {c2.Nome} - Juros Anual {c2.JurosAnual()}");


public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;
    
    public float JurosAnual()
    {
        return Juros * 12;
    }
}