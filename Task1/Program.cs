using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки массива через пробел:");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        // Подсчитываем количество строк, удовлетворяющих условию
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[count];

        // Заполняем новый массив подходящими строками
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}
