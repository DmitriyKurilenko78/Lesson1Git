// Задача 29: Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.Write("Введите массив чисел: ");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

  string input = Console.ReadLine();
  string[] values = input.Split(',');

        for (int i = 0; i < array.Length; i++) 
         array[i] = int.Parse(values[i]);
       
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
