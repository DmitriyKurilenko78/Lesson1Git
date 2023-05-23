// Задача 15: Напишите программу, которая принимает на вход цифру, 
//            обозначающую день недели, и проверяет, является ли этот день выходным.
//            6 -> да
//            7 -> да
//            1 -> нет


Console.Clear();
Console.Write("Введите число соответствующее дню недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
      Console.WriteLine("Не верное число\nВведите число: ");
          n = int.Parse(Console.ReadLine()!);  
}
if (n >= 1 && n <= 5)
    Console.Write("Нет");
else 
    Console.Write("Да");  