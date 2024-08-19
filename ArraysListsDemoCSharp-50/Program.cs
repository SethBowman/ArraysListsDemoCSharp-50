using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        //Arrays
        //Arrays have a set size that you define at creation of the array and that size cannot change
        int[] numbers = new int[] { 22, 4, 1, 100, 5 };

        //numbers[1] = 4000;

        // foreach (var number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
        
        //Arrays do have a property called "Length" that shows you the number of items in the Array

        //Console.WriteLine(numbers.Length - 1);

        var names = new string[] { "Seth", "Miah", "Cruz" };

        // for (int i = 0; i <= names.Length - 1; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        // for (int i = names.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(names[i]);
        // }
        
        //Lists
        //Lists have a size that you can change all you want
        List<int> numbersList = new List<int>() { 22, 3, 444, 5, 6, 444 };

        // foreach (var number in numbersList)
        // {
        //     Console.WriteLine(number);
        // }

        //Lists have a property called "Count" that shows you the number of items in the List

        var ourClass = new List<string>() { "Douglas", "Filip", "Isaac", "Jason", "julian", "Mariah", "Raynard", "Robert", "Samuel", "Seth", "Miah" };

        //Console.WriteLine(ourClass.Count - 1);

        for (int i = 0; i < ourClass.Count; i++)
        {
            Console.WriteLine(ourClass[i]);
        }

    }
}