﻿// Максимальное из трех введенных чисел
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(b>a)
{
    max=b;
}
if(c>b)
{
    max=c;
}
Console.WriteLine("Максимальное из трех: " + max);
