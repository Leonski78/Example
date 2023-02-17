// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.WriteLine("координаты A (X,y): ");
int x1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты A (x,Y): ");
int y1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты B (X,y): ");
int x2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты B (x,Y): ");
int y2 = int.Parse(Console.ReadLine()??"0");
double s = Math.Sqrt(((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)));
Console.WriteLine($"Расстояние между А и В равно: {s}");

