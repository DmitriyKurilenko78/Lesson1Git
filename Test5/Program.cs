// Задача 10: Напишите программу, которая принимает на вход  трёхзначное 
//              число и на выходе показывает вторую цифру этого числа.
//            456 -> 5
//            782 -> 8
//            918 -> 1

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)
{
      Console.Write("Вы ввели не верное число!\nВведите число: ");
       n = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(n / 10 % 10);