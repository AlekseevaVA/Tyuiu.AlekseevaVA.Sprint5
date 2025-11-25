using Tyuiu.AlekseevaVA.Sprint5.Task5.V3.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task5.V3;

internal class Program
{
    static void Main(string[] args)
    {


        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнилa: Алексеева В. А. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask5V3.txt.txt";

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Сумма всех целых чисел в файле = " + res);

        Console.ReadKey();
    }
}

