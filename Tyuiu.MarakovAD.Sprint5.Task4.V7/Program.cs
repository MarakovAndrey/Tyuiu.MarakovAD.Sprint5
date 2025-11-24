using Tyuiu.MarakovAD.Sprint5.Task4.V7.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c классом File                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V7.txt " +
            "(файл взять из архива согласно вашему варианту. Создать папку в ручную С:DataSprint5 " +
            "и скопировать в неё файл) в котором есть вещественное значение. Прочитать значение " +
            "из файла и подставить вместо Х в формуле . Вычислить значение по формуле " +
            "(Полученное значение округлить до трёх знаков после запятой) и вернуть полученный " +
            "результат на консоль.");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        string path = "C:/DataSprint5/InPutDataFileTask4V7.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}