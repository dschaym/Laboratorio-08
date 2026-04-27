Console.WriteLine("Negocio en registro de productos");
Console.WriteLine();
Console.Write("Ingrese el número de productos: ");
int productos = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de días: ");
int dias = int.Parse(Console.ReadLine());

int[,] ventas = new int[productos, dias];

for (int i = 0; i < productos; i++)
{
    Console.WriteLine("Producto " + (i + 1));
    for (int j = 0; j < dias; j++)
    {
        Console.Write("Día " + (j + 1) + ": ");
        ventas[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.Write("Ingrese el número del producto que desea ver: ");
int productoElegido = int.Parse(Console.ReadLine());

productoElegido = productoElegido - 1;

Console.WriteLine();
Console.WriteLine("Ventas del producto " + (productoElegido + 1));

for (int j = 0; j < dias; j++)
{
    Console.WriteLine("Día " + (j + 1) + ": " + ventas[productoElegido, j]);
}