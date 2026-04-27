Console.WriteLine("Tienda de control de productos");
Console.WriteLine();
Console.Write("Ingrese filas: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] inventario = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Valor: ");
        inventario[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz de inventario:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(inventario[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Número a buscar: ");
int buscar = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (inventario[i, j] == buscar)
        {
            Console.WriteLine("Fila " + i + " Columna " + j);
            encontrado = true;
        }
    }
}

if (encontrado == false)
{
    Console.WriteLine("No encontrado");
}