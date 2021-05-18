using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace CountWords
{
     class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText(@"/Semenkina/Text1.txt"); 

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine($"Количество слов в романе 'Обломов': {words.Length}");
            Console.WriteLine();

           //Поместим массив слов в Список
           List<string> list = new List<string>(words);

            //Поместим массив слов в связанный Список
            LinkedList<string> linkedList = new LinkedList<string>(words);

            // Запустим таймер 1-----------
            var watch1 = Stopwatch.StartNew(); ;

            list.Insert(0, "insert1");

            // Выведем результат
            Console.WriteLine($"Вставка в начало List: {watch1.Elapsed.TotalMilliseconds}  мс");

            // Запустим таймер 2-----------
            var watch2 = Stopwatch.StartNew(); ;

            linkedList.AddFirst("insert1");

            // Выведем результат
            Console.WriteLine($"Вставка в начало LinkedList: {watch2.Elapsed.TotalMilliseconds}  мс");

            Console.WriteLine();

            // Запустим таймер 3---------------
            var watch3 = Stopwatch.StartNew(); ;

            list.Add("insert2");

            // Выведем результат
            Console.WriteLine($"Вставка в конец List: {watch3.Elapsed.TotalMilliseconds}  мс");
 
            // Запустим таймер 4-----------
            var watch4 = Stopwatch.StartNew(); ;

            linkedList.AddLast("insert2");

            // Выведем результат
            Console.WriteLine($"Вставка в конец LinkedList: {watch4.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
