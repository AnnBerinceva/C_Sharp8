int a1 = ReadInt("Ввести значение 1 для первой точки ");
int b1 = ReadInt("Ввести значение 2 для первой точки ");
int c1 = ReadInt("Ввести значение 3 для первой точки ");
int a2 = ReadInt("Ввести значение 1 для второй точки ");
int b2 = ReadInt("Ввести значение 2 для второй точки ");
int c2 = ReadInt("Ввести значение 3 для второй точки ");

int A = a2 - a1;
int B = b2 - b1;
int C = c2 - c1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}