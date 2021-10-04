using System;
using System.Globalization;

namespace Homework_1_Task_2._1
{
    class Program
    {
        public static decimal NDS = 20;
        static void WriteToConsole(decimal price)
        {
            Console.WriteLine("Cтоимость без НДС: " + Math.Round(price / (NDS+100)*100, 2));
            Console.WriteLine("НДС: " + Math.Round(price *(NDS/(100+NDS)), 2));
            Console.WriteLine("НДС для налоговой: " + Math.Round(price / 6));
        }
        static void Main(string[] args)
        {
            NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint;
            CultureInfo culture = CultureInfo.CurrentCulture;

            Console.Write("Введите цену товара: ");
            decimal price;


            while (!decimal.TryParse(Console.ReadLine(), style, culture, out price) || price < 0 || price != Math.Round(price,2))
            {
                Console.Error.WriteLine("Вы вели что-то не то! Цена должна быть положительна с двумя знаками после запятой.");
                Console.Write("Введите цену товара: ");
            }

            WriteToConsole(price);

        }
    }
}
