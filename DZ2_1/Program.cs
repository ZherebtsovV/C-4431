Console.WriteLine("Hello, World!");
/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/


Console.Write("Введите трехзначное число число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA < 100 || numberA > 999)
{
Console.WriteLine($"Число {numberA} не трехзначное");
return;
}
Console.WriteLine($"Число {numberA} трехзначное");
int Second = numberA / 10 % 10;
Console.WriteLine($"Вторая цифра числа {numberA} - {Second}");
