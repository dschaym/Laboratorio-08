Console.WriteLine("Empresa de monitoreo ambiental");
Console.WriteLine();
Console.Write("Ingrese la cantidad de zonas: ");
int zonas = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de días: ");
int dias = int.Parse(Console.ReadLine());

double[,] temperaturas = new double[zonas, dias];

for (int i = 0; i < zonas; i++)
{
    Console.WriteLine("Zona " + (i + 1));
    for (int j = 0; j < dias; j++)
    {
        Console.Write("Día " + (j + 1) + ": ");
        temperaturas[i, j] = double.Parse(Console.ReadLine());
    }
}

Console.WriteLine();

for (int i = 0; i < zonas; i++)
{
    Console.Write("Zona " + (i + 1) + " | ");
    for (int j = 0; j < dias; j++)
    {
        Console.Write(temperaturas[i, j] + " | ");
    }
    Console.WriteLine();
}