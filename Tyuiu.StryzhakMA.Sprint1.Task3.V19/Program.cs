using Tyuiu.StryzhakMA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.StryzhakMA.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 1                                                              *");
            Console.WriteLine("* Тема: Операторы составного присваивателя                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Стрыжак Мария Андреевна | АСОиУб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1;
            Console.WriteLine("Введите значение X1");
            x1 = Convert.ToInt32(Console.ReadLine());

            double x2;
            Console.WriteLine("Введите значение X2");
            x2 = Convert.ToInt32(Console.ReadLine());

            double y1;
            Console.WriteLine("Введите значение Y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            double y2;
            Console.WriteLine("Введите значение Y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.ElephCanMove(x1, x2, y1, y2));

            Console.ReadLine();
        }
    }
}
