Console.WriteLine("## Conversão de tipos ##\n");

int varInt = 100;
double varDouble = varInt;

//short -> 2 bytes
//int -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;


Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

double varDouble1 = 12.456; //8 bytes
int varInt1 =(int)varDouble1; // 4 bytes (perda de precisão
Console.WriteLine(varInt1);

int num1 = 10;
int num2 = 4;

float resultado =(float) num1 / num2;
Console.WriteLine(resultado);

Console.ReadKey();
