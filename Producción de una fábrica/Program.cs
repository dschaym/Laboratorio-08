Console.WriteLine("Cantidad de productos fabricados, fábrica FACSSA");
Console.WriteLine();
Console.Write("Ingrese número de máquinas: ");
int maquinas = int.Parse(Console.ReadLine());

Console.Write("Ingrese número de turnos: ");
int turnos = int.Parse(Console.ReadLine());

int[,] produccion = new int[maquinas, turnos];
int total = 0;

for (int i = 0; i < maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        Console.Write("Producción: ");
        produccion[i, j] = int.Parse(Console.ReadLine());
        total = total + produccion[i, j];
    }
}

Console.WriteLine("Matriz de producción:");
for (int i = 0; i < maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        Console.Write(produccion[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Producción total: " + total);