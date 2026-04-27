Console.WriteLine("Videojuego 2.1");
Console.WriteLine();
Console.Write("Ingrese número de jugadores: ");
int jugadores = int.Parse(Console.ReadLine());

Console.Write("Ingrese número de niveles: ");
int niveles = int.Parse(Console.ReadLine());

int[,] puntajes = new int[jugadores, niveles];
int mayor = 0;

for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        Console.Write("Puntaje: ");
        puntajes[i, j] = int.Parse(Console.ReadLine());
        if (puntajes[i, j] > mayor)
        {
            mayor = puntajes[i, j];
        }
    }
}

Console.WriteLine("Matriz de puntajes:");
for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        Console.Write(puntajes[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Puntaje más alto: " + mayor);