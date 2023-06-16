Console.WriteLine("Hello, World!");

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int Ost = numberA % 2;
Console.WriteLine(Ost);

if (Ost == 0)
{
Console.WriteLine($"Число {numberA} четное");
}
else
{
Console.WriteLine($"Число {numberA} не четное");
}
