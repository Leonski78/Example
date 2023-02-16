// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int Third = int.Parse(Console.ReadLine()!);
if (N<100)
{
Console.WriteLine("Третьей цифры нет");
}
while (N>999)
    {
        Third = N/10;
    }
    Third = Third % 10;
Console.WriteLine("Третья цифра: " + Third);
