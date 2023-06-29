
Console.WriteLine("Hello, World!");

/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] GenArr (int len, int min, int max)
{
int[] array = new int[len];
Random random = new Random();
for (int i = 0; i < len; i++)
{
    array[i] = random.Next(min, max+1);
}
return array;
}

void PrnArr (int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]}, ");
}
Console.Write("]");
}

Console.Write("Введите длину массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимум: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимум: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int[] array = GenArr (numberA, numberB, numberC);
PrnArr (array);
