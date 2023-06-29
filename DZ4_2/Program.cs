Console.WriteLine("Hello, World!");

/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int SumNum (int numA)
{
    int numB = 0;

    while (numA > 1)
    {
      numB = numB + numA % 10;
      numA = numA / 10;  
    }
        return numB;
}


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

System.Console.Write($"Сумма = {SumNum(number)}: ");
