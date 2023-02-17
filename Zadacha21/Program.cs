// // Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write($"{number} -> ");

while (count <= number)
{
    Console.Write(Math.Pow(count,2));
    if (count!=number)
    {
        Console.Write(", ");
    }
    count ++;
}
// Console.Write($"{Math.Pow(count,2)}"+((count != n) ? ", " : "").ToString());
