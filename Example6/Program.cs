// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
// int Third = int.Parse(Console.ReadLine()!);
if (N<100)
{
Console.WriteLine("Третьей цифры нет");
}
if (N>99 && N<1000)
    {
        N = N % 10;
    }
else if (N>999)
{
    N = N / 10 % 10;
}  
return
// Third = Third % 10;
Console.WriteLine("Третья цифра: " + N);
