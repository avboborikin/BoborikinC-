using System;

class Program
{
    static void Main()
    {
        // Проверка, больше ли введённое число 7
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 7)
        {
            Console.WriteLine("Hello");
        }

        // Проверка, совпадает ли введённое имя с "John"
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (name.Equals("John", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Hello, John");
        }
        else
        {
            Console.WriteLine("There is no such name");
        }

        // Вывод элементов массива, которые кратны 3
        Console.Write("Enter araay splited by spaces: ");
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' '); // Изменено на разделение по пробелу
        int[] numbersArray = Array.ConvertAll(stringArray, int.Parse);

        Console.WriteLine("elements that are multiples of 3:");
        foreach (int num in numbersArray)
        {
            if ((num % 3 == 0) & (num != 0))
                Console.WriteLine(num);
        }
    }
}