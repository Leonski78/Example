// Максимальное из трех введенных чисел
Console.WriteLine("Enter number 1 ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number 2 ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number 3 ");
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
Console.WriteLine("Maximum = " + max);
