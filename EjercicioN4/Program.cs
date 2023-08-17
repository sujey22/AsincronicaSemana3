//Ejercicio numero 4

String[] palabras = { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

Console.WriteLine("Arreglo sin ordenar: ");
for (int i = 0; i < palabras.Length; i++)
{
    Console.WriteLine($"Posición {i + 1}: {palabras[i]}");
}

Array.Sort(palabras);

Console.WriteLine("\nArreglo ordenado: ");

foreach (string i in palabras)
{
    Console.WriteLine(i);
}



//Donde se le aplica la busqueda

Console.WriteLine("\nBusqueda con BinarySearch");

String[] palabraSearch = { "Sol", "Dedo", "Casa" };

foreach (string i in palabraSearch)
{
    int Posicion = Array.BinarySearch(palabras, i);

    if (Posicion >= 0)
    {
        Console.WriteLine($"la palabra '{i}' se encuentra en la posicion {Posicion}");
    }
    else
    {
        Console.WriteLine($"la palabra '{i}' no se encontro en el arreglo");
    }
}

