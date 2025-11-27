using Tyuiu.AlekseevaVA.Sprint5.Task7.V21.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task7.V21;

internal class Program
{
    static void Main(string[] args)
    {


        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнилa: Алексеева В. А. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Работа в С#                                                       *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\Users\виктория\Desktop\DataSprint5\InPutDataFileTask7V21.txt";
        string pathSaveFile = @"C:\Users\виктория\Desktop\DataSprint5\OutPutDataFileTask7V21.txt";

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);

        Console.ReadKey();
    }
}
