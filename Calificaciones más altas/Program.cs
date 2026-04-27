Console.WriteLine("Registro de calificaciones de Ing. Tello");
Console.WriteLine();
Console.Write("Ingrese número de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());

Console.Write("Ingrese número de evaluaciones: ");
int evaluaciones = int.Parse(Console.ReadLine());

double[,] notas = new double[estudiantes, evaluaciones];
double mayor = 0;

for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < evaluaciones; j++)
    {
        Console.Write("Nota: ");
        notas[i, j] = double.Parse(Console.ReadLine());
        if (notas[i, j] > mayor)
        {
            mayor = notas[i, j];
        }
    }
}

Console.WriteLine("Matriz de notas:");
for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < evaluaciones; j++)
    {
        Console.Write(notas[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Nota más alta: " + mayor);