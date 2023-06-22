Console.WriteLine("Hello, World!");
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
String strA = Console.ReadLine();
String strB = string.Empty;
int strLenA = strA.Length;

Console.WriteLine($"Число {strA}");
Console.WriteLine($"Длина числа = {strLenA}");

if (strLenA != 5)
{
Console.WriteLine($"Число {strA} не пятизначное");
return;
}
Console.WriteLine($"Число {strA} пятизначное");

for (int i = strLenA-1; i >= 0; i--)
{
   //Console.WriteLine(i);
   strB = strB + strA[i];
}
Console.WriteLine($"Обратное число {strB}");
int numberA = Convert.ToInt32(strA);
int numberB = Convert.ToInt32(strB);

if (numberA == numberB)
{
Console.WriteLine($"Число {strA} полиндром");
return;
}
Console.WriteLine($"Число {strA} не полиндром");
