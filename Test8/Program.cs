// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
string str = n.ToString();
while (str.Length < 4 || str.Length > 4)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = int.Parse(Console.ReadLine()!);
}

if (str[0] == str[4] && str[1] == str[3])
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
