Console.WriteLine("Asistencia de estudiantes");
Console.WriteLine();
Console.Write("Ingrese número de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());

Console.Write("Ingrese número de días: ");
int dias = int.Parse(Console.ReadLine());

int[,] asistencia = new int[estudiantes, dias];

for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write("Asistencia: ");
        asistencia[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz de asistencia:");
for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write(asistencia[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Seleccione estudiante: ");
int est = int.Parse(Console.ReadLine()) - 1;

for (int j = 0; j < dias; j++)
{
    Console.WriteLine(asistencia[est, j]);
}