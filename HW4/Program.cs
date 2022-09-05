/Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*

int Stepen(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++)
    {
    result = result * numA;
    }
        return result;
}

  Console.Write("Введите A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  int stepen = Stepen(numA, numB);
  Console.WriteLine($"{numA} в {numB} степени = {stepen}");
//_______________________________________________________________________________________________________________________
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число больше 9: ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNum(int num)
  {
    int count = Convert.ToString(num).Length;
    int temp = 0; int result = 0;

    for (int i = 0; i < count; i++)
    {
      temp = num - num % 10;
      result = result + (num - temp);
      num = num / 10;
    }
   return result;
  }

int sumNum = SumNum(num);
Console.WriteLine($"сумма цифр числа {num} = {sumNum}");
//_______________________________________________________________________________________________________________________
 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < 8; i++)
 {
    numbers [i] = new Random().Next(0, 99);
    Console.Write(" " + Mass (i));
    {
        if (i<7)
         Console.Write(",");
        else break;
    }
 }

Console.Write("]");

int Mass (int a)
{
    return numbers[a];
}