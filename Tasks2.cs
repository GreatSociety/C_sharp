using System;

class Program
{
    public static void Main()
    {
        // #1. Дан массив, необходимо заполнить его значениями от 0 до 999 и найти произведение всех нечетных элементов
        int[] numbers = new int[1000];
        int oddSum = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;

            if (i % 2 != 0)
            {
                oddSum *= i;
            }
        }

        // Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine(oddSum);

        // #2. Дан массив символов, необходимо преобразовать его в строку
        char[] symbols = new char[] { 'd', 'o', 'n', 'e' };
        string word = "";

        foreach (var symb in symbols)
        {
            word += symb;
        }

        Console.WriteLine(word);

        // #3. Даны 2 строки, необходимо зеркально отразить каждую строку и вывести в консоль друг за другом
        string first = "llaF";
        string second = "tuo";
        string third = "sageV weN"; 
        string[] wordArray = { first, second, third };

        foreach (var element in wordArray)
        {
            Console.WriteLine(ReverseWord(element));
        }

        // Или если друг за другом значит - в одну строку.
        // Console.WriteLine(ReverseWord(first) + ReverseWord(second) + " " + ReverseWord(third));

        Console.ReadKey();
    }

    static string ReverseWord(string word)
    {
        char[] array = word.ToCharArray();

        string wordRev = "";

        for (int i = array.Length - 1; i >= 0; i--)
        {
            wordRev += array[i];
        }

        return wordRev;
    }
}   