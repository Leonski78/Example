// программа, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве
Console.Clear();
Console.WriteLine("координаты A (X): ");
int x1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты A (Y): ");
int y1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты A (Z): ");
int z1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты B (X): ");
int x2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты B (Y): ");
int y2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("координаты B (Z): ");
int z2 = int.Parse(Console.ReadLine()??"0");
double s = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между А и В равно: {s:f2}");