//Ejercicio numero 2

String[] NombreCompleto = { "Merlin", "Sujey", "Duarte", "Argueta" };

Console.WriteLine("Valores del arreglo: ");

foreach (var i in NombreCompleto)
{
    Console.WriteLine(i);
}

int Tamañoarreglo = NombreCompleto.Length;

Console.WriteLine($"\nTamaño del arreglo: {Tamañoarreglo}");

Console.WriteLine("\nTamaño del arreglo y valores: ");

for(int i = 0; i < Tamañoarreglo; i++)
{
    Console.WriteLine($"Posicion {i + 1}: {NombreCompleto[i]}" );
}