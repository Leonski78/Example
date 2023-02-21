// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(int n) 
{
  int count = 0;
  while (n > 0) {
    n = n/10;
    count++;
  }

  return count; 
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{n} -> {GetNumber(n)}");
