Console.WriteLine("Hello, World!");
/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
String strA = Console.ReadLine();
int numberA = Convert.ToInt32(strA);
int strLenA = strA.Length;

if (numberA < 0)
{
strLenA = strA.Length-1;
}
numberA = Math.Abs(numberA);

//Console.WriteLine($"Число {numberA}");
//Console.WriteLine($"Длина числа {numberA} равна {strLenA}");

if (strLenA < 3)
{
Console.WriteLine($"В числе {numberA} третьей цифры нет");
return;
}

int third = numberA;
for (int i = strLenA-3; i > 0; i--)
{
    third = third / 10;
}

third = third % 10;
Console.WriteLine($"В числе {numberA} третья цифра {third}");
