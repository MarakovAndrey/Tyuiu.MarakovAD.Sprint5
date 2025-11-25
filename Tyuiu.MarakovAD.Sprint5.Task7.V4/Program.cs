using Tyuiu.MarakovAD.Sprint5.Task7.V4.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Мараков А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы c классом File                              *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Мараков Андрей Дмитриевич | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask7V4.txt " +
            "(файл взять из архива согласно вашему варианту. Создать папку в ручную " +
            "С:DataSprint5 и скопировать в неё файл) в котором есть набор символьных данных." +
            "Заменить все русские буквы на #.Полученный результат сохранить в файл " +
            "OutPutDataFileTask7V4.txt.");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        string path = "C:/DataSprint5/InPutDataFileTask7V4.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.LoadDataAndSave(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}