// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Варианты:
// var n = 12345;
// var arr = n.toString().split('');
// for (i = 0; i < arr.length; i++) arr[i] = +arr[i] | 0;
// int[] N = new int[5];
// if (N[0]=N[4] + N[1]=N[3])
Console.Clear();
Console.WriteLine("Введите пятизначное число N: ");
int N = int.Parse(Console.ReadLine()!);
int Temp = N;
int rev = 0;
while (Temp>0)
{
    int dig = Temp % 10;
    rev = rev * 10 + dig;
    Temp = Temp/10;
}
if (N == rev)
{
    Console.WriteLine("Это палиндром !");
}
else
{
    Console.WriteLine("Это не палиндром !");
}


