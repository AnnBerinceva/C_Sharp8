int num = ReadInt("Число N ");

for (int a = 1; a <= num; a++)
{
    Console.WriteLine($"{a*a*a} "); 
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}