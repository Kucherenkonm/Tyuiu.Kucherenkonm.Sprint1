using Tyuiu.Kucherenkonm.Sprint1.Task5.V3.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*            Написать программу, которая решает следующую задачу:         *");
        Console.WriteLine("*  Присвоить переменной h третью от конца цифру в записи положительного   *");
        Console.WriteLine("*                         целого числа k                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int h, k;

        Console.WriteLine("Введите значение k:");
        k = Convert.ToInt32(Console.ReadLine());

        h = Convert.ToInt32(ds.Calculate(k));

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Третья от конца цифра в записи целого положительного числа к: " + h);
        Console.ReadKey();

    }
}