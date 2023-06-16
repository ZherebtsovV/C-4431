// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int quater = number * number;
Console.WriteLine($"Квадрат числа {number} = {quater}");
