// // программа, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
int m = N;
if (N<0)
{
    i = N;
    m = -N;
    N = -1;
} 
int[]result = new int [m];
for (int j = 0; i <= N; i++)
{
    result[j] = i*i*i;
    j++;
}
Console.Write($"Кубы числа от 1 до N: ");
for (int j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}
