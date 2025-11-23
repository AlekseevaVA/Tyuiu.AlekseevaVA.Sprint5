using Tyuiu.AlekseevaVA.Sprint5.Task1.V22.Lib;

namespace Tyuiu.AlekseevaVA.Sprint5.Task1.V22;

internal class Program
{
    static void Main(string[] args)
    {
     
        int startValue = -5;
        int stopValue = 5;

        DataService ds = new DataService();
        
        Console.Title = "Спринт #5 | Выполнилa: Алексеева В. А. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Дано выражение. Вычислить его значение при x = 4, результат сохранить   *");
        Console.WriteLine("* в текстовый файл 'OutPutFileTask0.txt' и вывести на консоль.            *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
       

        Console.WriteLine("startValue = "+ startValue);
        Console.WriteLine("stopValue = "+ stopValue );

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Файл: " + ds.SaveToFileTextData(startValue, stopValue));
        Console.WriteLine("Создан");
        Console.ReadKey();
    }
}