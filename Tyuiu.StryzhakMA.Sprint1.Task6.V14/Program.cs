using Tyuiu.StryzhakMA.Sprint1.Task6.V14.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Стрыжак М.А. | АСОиУб-26-1"; 
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Стрыжак М.А.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
            Console.WriteLine("* составлена только из строчных русских букв.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.WriteLine("Введите текст:");
            string? text = Console.ReadLine();
            if (text == null)
            {
                text = "";
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            bool result = ds.CheckLowerCaseRusLetters(text);

            if (result)
            {
                Console.WriteLine("Строка составлена ТОЛЬКО из строчных русских букв.");
            }
            else
            {
                Console.WriteLine("Строка содержит другие символы (заглавные буквы, цифры, пробелы и т.д.).");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
