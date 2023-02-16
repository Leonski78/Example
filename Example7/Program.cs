// программа, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным
Console.Clear();
Console.WriteLine("Введите день недели: ");
int a = int.Parse(Console.ReadLine()!);
if (a>5 && a<8)
{
    Console.WriteLine("Ура! Это выходной");
    }
if (a>0 && a<6)
{
    Console.WriteLine("Увы, Это рабочий день");
}
if (a<0 || a>7)
{
    Console.WriteLine("Это не день недели 8-)");
}