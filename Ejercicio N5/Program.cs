// Ejercicio numero 5

using System;

int[] Numero = { 4, 10, 45, -67, -7, 25, 89, 64 };

Console.WriteLine("Arreglo en el orden original");

foreach(int i in Numero)
{
    Console.WriteLine(i);
}

Array.Reverse(Numero);
Console.WriteLine("\nArreglo con Reverse");

foreach (int i in Numero)
{
    Console.WriteLine(i);
}

Array.Sort(Numero);
Console.WriteLine("\nArreglo con Sort");
foreach (int i in Numero)
{
    Console.WriteLine(i);
}