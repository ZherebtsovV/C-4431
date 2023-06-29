
Console.WriteLine("Hello, World!");
/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int sumNech = 0;

for (int i = 0; i < array.Length; i++)
{
if ((i+1) % 2 == 1)
{
sumNech = sumNech + array[i];
System.Console.WriteLine($"Сумма {sumNech}, i= {i}");
}
}
System.Console.WriteLine($"Сумма на нечетных = {sumNech}");
