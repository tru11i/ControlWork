using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string[] inputArray = Console.ReadLine().Split(',');

        // Формирование нового массива
        string[] resultArray = FilterArray(inputArray);

        // Вывод результатов
        Console.WriteLine("Исходный массив:");
        PrintArray(inputArray);

        Console.WriteLine("Новый массив:");
        PrintArray(resultArray);
    }
}