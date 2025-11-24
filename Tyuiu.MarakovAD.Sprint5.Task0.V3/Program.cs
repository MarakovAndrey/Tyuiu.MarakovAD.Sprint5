using Tyuiu.MarakovAD.Sprint5.Task1.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c классом File                              *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция, произвести табулирование на заданном диапозоне чисел. " +
            "Результат вывести в файл.");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        int x = -5;
        Console.WriteLine("StartValue = " + startValue);
        Console.WriteLine("StopValue = " + stopValue);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("+--------+--------+");
        Console.WriteLine("|   x    +   f    |");
        Console.WriteLine("+--------+--------+");
        for (int i = -5; i <= 5; i++)
        {
            Console.WriteLine("|{0,5:d}    |   {1, 5:f2}    |", x, Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x, 2));
            x++;
        }
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}