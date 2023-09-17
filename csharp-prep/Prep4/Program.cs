using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int num = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (num != 0)
        {
            Console.Write("Enter number: ");

            string userInput = Console.ReadLine();
            num = int.Parse(userInput);

            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {min}");


        numbers.Sort();
        Console.WriteLine($"The numbers in ascending order are: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        numbers.Reverse();
        Console.WriteLine($"The numbers in descending order are: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}