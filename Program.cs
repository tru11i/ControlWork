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

     // Метод для фильтрации массива
    static string[] FilterArray(string[] inputArray)
    {
        // Используем List для динамического добавления строк
        System.Collections.Generic.List<string> resultList = new System.Collections.Generic.List<string>();

        // Фильтрация и добавление строк в List
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultList.Add(item);
            }
        }

        // Преобразование List в массив
        string[] resultArray = resultList.ToArray();

        return resultArray;
    }

     // Метод для вывода массива
    static void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}