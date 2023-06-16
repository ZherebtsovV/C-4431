Console.WriteLine("Hello, World!");

/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA >= 0)
{
for (int i = 2; i <= numberA;)
{
    Console.Write($"{i}, ");
    i = i+2;
}
}
else
{
for (int i = -2; i >= numberA;)
{
    Console.Write($"{i}, ");
    i = i-2;
}
}
