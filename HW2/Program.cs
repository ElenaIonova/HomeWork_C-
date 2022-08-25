/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
//от случайного числа

int Pack(int num)
{
    int num2, res;

    num2 = (num / 10) % 10;
       
    return  num2;
}

int randNum = new Random().Next(100, 1000);
int num2 = Pack(randNum);

Console.WriteLine ($"{num2} является второй цифрой числа {randNum}");

//от конкретного числа

int Pack(int num)
{
    int num2, res;
    num2 = num / 10;
    res = num2 % 10;
       
    return res;
}
Console.Write("введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = Pack(num);
Console.WriteLine ($"{res} является второй цифрой числа {num}");

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
*/

Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Num);
if (NumText.Length > 2)
{
  Console.WriteLine(NumText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введи число, обозначающее день недели, где 1-пн,..,7-вс: ");
int num = Convert.ToInt32(Console.ReadLine());
void Day (int num)
{
    int a=6, b=7;
    if(num==a)
        Console.Write("да");
        else if(num==b)
        Console.Write("да");
   
    else
    
    Console.Write("нет");
    
}
Day(num);
