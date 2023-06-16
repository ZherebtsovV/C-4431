Console.WriteLine("Hello, World!");
/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());

switch (numberA)
{
    case 1:
        Console.WriteLine($"Понедельник {numberA} - не выходной");
        break;
    case 2:
        Console.WriteLine($"Вторник {numberA} - не выходной");
        break;
    case 3:
        Console.WriteLine($"Среда {numberA} - не выходной");
        break;
    case 4:
        Console.WriteLine($"Четверг {numberA} - не выходной");
        break;
    case 5:
        Console.WriteLine($"Пятница {numberA} - не выходной");
        break;
    case 6:
        Console.WriteLine($"Суббота {numberA} - выходной");
        break;
    case 7:
        Console.WriteLine($"Воскресенье {numberA} - выходной");
        break;
    default:
        Console.WriteLine("Неверный день");
        break;
}
