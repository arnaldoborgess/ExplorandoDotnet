using System;
int numero = 20;
bool ehPar = false;

// IF Ternario

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));




/*
if (numero % 2 == 0)
{
    System.Console.WriteLine($"O número {numero} é par");
}
else
{
    System.Console.WriteLine($"O número {numero} é impar");
}
*/