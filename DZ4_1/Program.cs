Console.WriteLine("Hello, World!");
/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Power (int numA, int numB)
{
    int power = 1;

    for (int i = 0; i < numB; i++)
    {
    power = power * numA;
    }

    return power;
}

Console.Write("Введите основание: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberB <= 0)
{
Console.WriteLine($"Показатель степени {numberB} должен быть больше 0");
return;
}

/*int numberC = 1;
for (int i = 0; i < numberB; i++)
{
numberC = numberC * numberA;
}*/

Console.Write($"Число {numberA} в степени {numberB} равно {Power (numberA, numberB)} ");
