// программа, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
if (N<100 || N>999)
{
    Console.Write($"{N} не трехзначное число");
}
else 
{int Second = N / 10 % 10;
Console.WriteLine($"Вторая цифра числа {N} -> {Second}");
}