class Program
{
    static void Main(string[] args)
    {
        // Вводим исходный массив строк
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] array = input.Split(',');

        // Создаем новый массив для хранения строк длиной <= 3 символа
        string[] newArray = new string[array.Length];
        int index = 0;

        // Перебираем исходный массив и добавляем строки длиной <= 3 в новый массив
        foreach (string s in array)
        {
            if (s.Length <= 3)
            {
                newArray[index] = s;
                index++;
            }
        }

        // Выводим новый массив на экран
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
