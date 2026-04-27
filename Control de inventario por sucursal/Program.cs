Console.WriteLine("Empresa de sucursales");
Console.WriteLine();
Console.Write("Ingrese el numero de sucursales: ");
int sucursales = int.Parse(Console.ReadLine());
Console.Write("Ingrese el numero de productos: ");
int productos = int.Parse(Console.ReadLine());

int[,] inventario = new int[sucursales, productos];
for (int i = 0; i < sucursales; i++)
{
    for (int j = 0; j < productos; j++)
    {
        Console.Write("Cantidad " + (i + 1) + ": ");
        inventario[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz de inventario:");
for (int i = 0; i < sucursales; i++)
{
    for (int j = 0; j < productos; j++)
    {
        Console.Write(inventario[i, j] + " | ");
    }
    Console.WriteLine();
}

Console.Write("Seleccione sucursal: ");
int s = int.Parse(Console.ReadLine()) - 1;

for (int j = 0; j < productos; j++)
{
    Console.WriteLine(inventario[s, j]);
}