using Tyuiu.AlekseevaVA.Sprint5.Task4.V4.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task4.V4;

internal class Program
{
    static void Main(string[] args)
    {

        
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнилa: Алексеева В. А. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask4V0.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();


        Console.ReadKey();
    }
}
