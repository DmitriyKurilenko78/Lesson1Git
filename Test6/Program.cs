// Задача 13: Напишите программу, которая выводит третью  цифру заданного числа или сообщает, 
//            что третьей цифры нет.  
//            645 -> 5
//            78 -> третьей цифры нет
//            32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n >= 1 && n < 100)

    Console.WriteLine("Третьей цифры нет");
   
else if (n >= 100 && n < 999)
         Console.WriteLine(n % 10); 
else if (n >= 1000 && n < 9999)
         Console.WriteLine(n / 10 % 10); 
else
    Console.WriteLine(n / 100 % 10);

  // Второй вариант  

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// string str = number.ToString();
// Console.WriteLine(str[2]);