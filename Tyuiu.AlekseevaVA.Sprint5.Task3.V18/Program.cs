using Tyuiu.AlekseevaVA.Sprint5.Task3.V18.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task3.V18;

internal class Program
{
    static void Main(string[] args)
    {

        int x = 2;
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнилa: Алексеева В. А. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine(" Создан!");
        

        Console.ReadKey();
    }
}