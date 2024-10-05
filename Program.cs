using System;
using TextUtilsLibrary;

namespace TextApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст для проверки на палиндром:");
            string? inputText = Console.ReadLine();

            // Проверка на палиндром
            bool isPalindrome = TextUtils.IsPalindrome(inputText);
            Console.WriteLine($"Является ли палиндромом: {isPalindrome}");

            // Подсчет количества предложений
            int sentenceCount = TextUtils.CountSentences(inputText);
            Console.WriteLine($"Количество предложений: {sentenceCount}");

            // Переворот строки
            string reversedText = TextUtils.ReverseString(inputText);
            Console.WriteLine($"Перевернутая строка: {reversedText}");

            Console.ReadLine();
        }
    }
}
