//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] GenerateRandomArray(int size, int start, int end)
    {
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        RandomArray[i] = new Random().Next(start, end + 1);
        }
    return RandomArray;
    }

void ShowArray(int[] Array1)
    {
    for (int i = 0; i < Array1.Length; i++)
        {
        Console.WriteLine(Convert.ToString(Array1[i]));
        }
    }
int CountOfEven(int[] myArray2)
    {
    int Count = 0;
    for (int i = 0; i < myArray2.Length; i++)
    if (myArray2[i] % 2 == 0)
        {
        Count = Count + 1;
        }
    return Count;
    }
int[] myArray = new int[5];
myArray = GenerateRandomArray(5, 100, 999);

ShowArray(myArray);
Console.WriteLine("количество четных чисел массива " + CountOfEven(myArray));
      
//---------------------------------------------------------------
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Write("Введи размер массива: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int RandomNum(int num, int min, int max)
  {
  int[] randomNum = new int[num];
  int sum = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNum.Length; i++ ){
      randomNum[i] = new Random().Next(min, max);

      Console.Write(randomNum[i] + " ");

      if (i % 2 != 1)
      {
        sum = sum + randomNum[i];
      }
    }
  return sum;
  }

int randomNum =  RandomNum(num, 1, 10);

Console.WriteLine($"Сумма: {randomNum}");
*/
//----------
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int z = 0; z < numbers.Length; z++)
    {
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
    }

Console.WriteLine($"Максимум = {max}, минимум = {min}");
Console.WriteLine($"Разница = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

