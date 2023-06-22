Console.WriteLine("Hello, World!");

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double Distance3D(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
double distance = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));
return Math.Round(distance, 2);
}

System.Console.Write("Введите координату Х точки А: ");
double Ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки А: ");
double Ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки А: ");
double Az = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Х точки B: ");
double Bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
double By = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки B: ");
double Bz = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками A и B равно {Distance3D(Ax, Ay, Az, Bx, By, Bz)}");
