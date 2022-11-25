Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int run = number.Length;
if (run == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Является Палиндромом");
    }
    else 
    {
        Console.WriteLine($"{number} - Не Является Палиндромом");
    }
}
