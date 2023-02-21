//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

int Factorial(int n) 
{
  int result = 1;
  for (int i = 1; i <= n; i++){
      result *= i;//result = result * i;
  }
  return result;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Фаториал !{n} -> {Factorial(n)}");


// для отрицательных
int GetMultiply(int n){ // n=3
    int result = 1;
    int i = 2;
    if( n < 0){
        i = n;
        n = -1;
    }
    for (; i <= n; i++){ // i <= n; 2 <= 3
        result *= i; // result
    }
    return result;
}

//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// int a = new Random().Next(2)
int[] arrray = BinaryArray(10);
Console.WriteLine($"{String.Join(", " , array)}");

