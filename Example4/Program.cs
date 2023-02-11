// Вывести четные числа от 1 до N
Console.WriteLine("Введите целое число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Четные числа до " + N + ":");
for (int i=1; i<N; i++)
{
    if(i%2==0)
    {
        Console.Write(i + ", ");
    }

}  