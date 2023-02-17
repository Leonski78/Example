// Поиск четверти на координатной плоскости
Console.WriteLine("Введите номер четверти от 1 до 4: ");
int a = int.Parse(Console.ReadLine()??"0");
if (a==1)
{
   Console.WriteLine("X>0, Y>0");
   }
   else if (a==2)
   {
    Console.WriteLine("X<0, Y>0");
   }
   else if (a==3)
   {
    Console.WriteLine("X<0, Y<0");
   }
else if (a==4)
   {
    Console.WriteLine("X>0, Y>0");
   }
   else 
   {
    Console.Write("Вы ввели некорректный номер четверти");
   }
       
 