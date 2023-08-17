//Ejercicio numero 3

String[] palabras = { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

Console.WriteLine("Arreglo sin ordenar: ");
for (int i = 0; i < palabras.Length; i++)
{
    Console.WriteLine($"Posición {i + 1}: {palabras[i]}");
}

Array.Sort(palabras);

Console.WriteLine("\nArreglo ordenado: ");

foreach(string i in palabras)
{
    Console.WriteLine(i);
}