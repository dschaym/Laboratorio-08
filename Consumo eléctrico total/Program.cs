Console.WriteLine("Consumo de distintos apartamentos");
Console.WriteLine();
Console.Write("Ingrese el número de apartamentos: ");
int apartamentos = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de días: ");
int dias = int.Parse(Console.ReadLine());

double[,] consumo = new double[apartamentos, dias];
double total = 0;

for (int i = 0; i < apartamentos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write("Consumo del apartamento " + (i + 1) + " dia " + (j + 1) + ": ");
        consumo[i, j] = double.Parse(Console.ReadLine());
        total += consumo[i, j];
    }
}
Console.WriteLine("Consumo total: " + total);