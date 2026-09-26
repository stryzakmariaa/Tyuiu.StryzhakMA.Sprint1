using Tyuiu.StryzhakMA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSetvice ds = new DataSetvice();

            Console.Title = "Спринт #1 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Стрыжак Мария Андреевна | АСОиУб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение      *");
            Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели (понедельник,     *");
            Console.WriteLine("* вторник,..., воскресенье) приходится k-й день невисокосного года,       *");
            Console.WriteLine("* в котором 1 января – понедельник.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            Console.Write("Введите число k (от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            
            int n = ds.Calculate(k);

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"k = {k}, n = {n}");

            
            Console.ReadKey();
        }
    }
}
