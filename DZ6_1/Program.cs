Console.WriteLine("Hello, World!");

/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
//Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
System.Console.Write($"Введите элемент № {i}: ");
arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}

System.Console.Write("Введите кол-во чисел: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int n = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
n +=1;
}
}
System.Console.WriteLine($"Положительных = {n}");
