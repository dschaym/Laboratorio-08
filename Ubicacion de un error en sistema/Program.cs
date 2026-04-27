Console.WriteLine("Sistema de errores");
Console.WriteLine();
Console.Write("Ingrese filas: ");
int filas = int.Parse(Console.ReadLine());
Console.Write("Ingrese columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] errores = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Código " + (i + 1)+": ");
        errores[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Matriz de errores:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(errores[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Código a buscar: ");
int codigo = int.Parse(Console.ReadLine());

bool existe = false;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (errores[i, j] == codigo)
        {
            Console.WriteLine("Fila " + i + " Columna " + j);
            existe = true;
        }
    }
}

if (existe == false)
{
    Console.WriteLine("No existe");
}