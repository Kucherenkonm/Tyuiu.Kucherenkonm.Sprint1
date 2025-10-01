using Tyuiu.Kucherenkonm.Sprint1.Task3.V4.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*       Написать программу вычисления стоимости покупки, состоящей из     *");
        Console.WriteLine("*         нескольких тетрадей и такого же количества обложек к ним        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double PriceNote = 2.75;
        double PriceCover = 0.5;
        int quantity = 7;
        Console.WriteLine(" Цена тетради (руб): " + PriceNote);
        Console.WriteLine(" Цена обложки (руб): " + PriceCover);
        Console.WriteLine(" Количество комплектов (шт): " + quantity);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Стоимость покупки составит: " + ds.PurchaseAmount(PriceNote, PriceCover, quantity));
        Console.ReadKey();


        Console.ReadKey();

    }
}