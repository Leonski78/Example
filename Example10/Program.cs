//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

int GetNumber(int n) 
{
  int result = 1;
  for (int i = 1; i <= n; i++){
      result = result * i;
  }
  return result;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{n} -> {GetNumber(n)}");
