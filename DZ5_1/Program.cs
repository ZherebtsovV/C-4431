
Console.WriteLine("Hello, World!");
/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 1000);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int chetn = 0;
int n = 0;

for (int i = 0; i < array.Length; i++)
{
n = array[i] % 2;
//Console.WriteLine($"Количество {chetn}, {n}");
if (n == 0)
{
chetn = chetn +1;
}
}
System.Console.WriteLine($"Количество четных = {chetn}");
