using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string inputText = "Створiть фiльтр визначених виразiв. Метод буде приймати вхiдний рядок, i повертати результат, де визначенi слова будуть замiненi на новi. Обробiть хоча б одне таке слово, тiльки передбачте безлiч його форм.";

        // Визначення слова, яке ми шукаємо і замінюємо
        string word = "метод";

        // Виклик фільтра для заміни слова
        string newFilter = FilterText(inputText, word);

        Console.WriteLine("Вихiдний текст:");
        Console.WriteLine(inputText);
        Console.WriteLine("\nТекст пiсля фiльтрацiї:");
        Console.WriteLine(newFilter);
    }

    static string FilterText(string inputText, string wordToReplace)
    {
        // Визначення регулярного виразу для знаходження слова з різними формами
        string pattern = @"\b" + Regex.Escape(wordToReplace) + @"s?\b"; // Враховуємо можливі форми слова

        // Виконуємо заміну знайдених слів на нове значення
        string filteredText = Regex.Replace(inputText, pattern, "ЗАМIНА", RegexOptions.IgnoreCase);

        return filteredText;
    }
}
