/*
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначно число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine("да");
  }
  else Console.WriteLine("нет");
}
CheckingNumber(number);
//----------------------------------------------------------------------------
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Input X of Dot A coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y of Dot A coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Z of Dot A coordinate: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input X of Dot B coordinate: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Y of Dot B coordinate: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Z of Dot B coordinate: ");
double zB = Convert.ToDouble(Console.ReadLine());


double LengthBetweenDots(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double xCat = xB - xA;
    double yCat = yB - yA;
    double zCat = zB - zA;
    return Math.Sqrt(xCat * xCat + yCat * yCat + zCat * zCat);
 }

double Len = Math.Round (LengthBetweenDots(xA, yA, zA, xB, yB, zB), 2);

Console.WriteLine($"Length of your line is: {Len}.");

//----------------------------------------------------------------------------------------------------------
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

*/
Console.Write("Введите число: ");
int cub = Convert.ToInt32(Console.ReadLine());

void Cub(int[] cub)
{
  int counter = 0;
  int length = cub.Length;
  while (counter <  length)
  {
    cub[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] kolich)
{
  int count = kolich.Length;
  int index = 1;
  while(index < count)
  {
        Console.Write(kolich[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cub+1];
Cub(arry);
PrintArry(arry);

