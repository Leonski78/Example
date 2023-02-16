// программа, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
int Second = N / 10 % 10;
Console.WriteLine($"Вторая цифра числа {N} -> {Second}");