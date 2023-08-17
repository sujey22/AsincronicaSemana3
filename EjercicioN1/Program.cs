//Inicio del ejercicio numero 1

int t;
do
{
    Console.WriteLine("ingrese el tamaño del arreglo (minimo 5): ");
} while(!int.TryParse(Console.ReadLine(), out t) || t < 5); 

float[] stock = new float[t];

for (int i = 0; i < stock.Length; i++)
{
    Console.WriteLine($"ingrese el valor para la posición: ");
    stock[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine("Valores ingresados: ");
foreach (int i in stock)
{
    Console.WriteLine(i);
}
