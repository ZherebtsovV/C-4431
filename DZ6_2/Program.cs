
Console.WriteLine("Hello, World!");

/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, 
 y = k2 * x + b2; 
  значения b1, k1, b2 и k2 задаются пользователем. */

System.Console.Write("Введите K1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите B1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите K2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите B2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write($"Уравнения y = {k1}x + {b1} , y = {k2}x + {b2}  ");

if (k1 == k2 && b1 == b2)
{
Console.Write("Прямые совпадают");
return;
}

if (k1 == k2)
{
Console.Write("Прямые параллельны");
return;
}

double x = (b2 - b1) / (k2 - k1);
double y = k1 * x + b1;

Console.Write($"Координаты =  ({x}, {y})");
