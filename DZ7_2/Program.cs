
Console.WriteLine("Hello, World!");

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void FillMatrixWithRandom(int[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 10);
}
}
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} ");
}
System.Console.WriteLine();
}
}

void PrintElement(int[,] matrix, int rowEl, int colEl)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if ((i == rowEl-1) && (j == colEl-1))
{
    System.Console.Write($"Элемент {matrix[i, j]} ");
    return;
}

}
System.Console.WriteLine();
}
    System.Console.Write("Такого элемента нет");
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);

System.Console.WriteLine("Введите строку элемента: ");
int rowE = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите столбец элемента: ");
int colE = Convert.ToInt32(Console.ReadLine());
PrintElement(matrix, rowE, colE);
