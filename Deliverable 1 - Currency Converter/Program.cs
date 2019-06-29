using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Deliverable_1__Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat1 = true, repeat2 = true, repeat3 = true;
            double firstNumber = 0, secondNumber = 0, thirdNumber = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (repeat1 == true)
            {
                Console.WriteLine("Type a dollar amount.");
                string firstNumberString = Console.ReadLine();
                if (Double.TryParse(firstNumberString, out firstNumber))
                {
                    repeat1 = false;
                }
                else
                {
                    Console.WriteLine("Unrecognized input. Please try again.");
                    repeat1 = true;
                }
            }
            while (repeat2 == true)
            {
                Console.WriteLine("Type a second dollar amount.");
                string secondNumberString = Console.ReadLine();
                if (Double.TryParse(secondNumberString, out secondNumber))
                {
                    repeat2 = false;
                }
                else
                {
                    Console.WriteLine("Unrecognized input. Please try again.");
                    repeat2 = true;
                }
            }
            while (repeat3 == true)
            {
                Console.WriteLine("Type a third dollar amount.");
                string thirdNumberString = Console.ReadLine();
                if (Double.TryParse(thirdNumberString, out thirdNumber))
                {
                    repeat3 = false;
                }
                else
                {
                    Console.WriteLine("Unrecognized input. Please try again.");
                    repeat3 = true;
                }
            }

            double totalNumber = (firstNumber + secondNumber + thirdNumber);
            totalNumber = Math.Round(totalNumber, 2);

            double average = Math.Round((totalNumber / 3), 2);
            double smallest = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
            double largest = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            Console.WriteLine();
            Console.WriteLine("The total number:" + totalNumber);
            Console.WriteLine("The average number:" + average);
            Console.WriteLine("The smallest number:" + smallest);
            Console.WriteLine("The largest number:" + largest);

            CultureInfo us = new CultureInfo("en-US");
            CultureInfo swed = new CultureInfo("sv-SE");
            CultureInfo jap = new CultureInfo("ja-JP");
            CultureInfo thai = new CultureInfo("th-TH");

            Console.WriteLine();
            Console.WriteLine("The amount in US Dollars: " + totalNumber.ToString("C", us));
            Console.WriteLine("The amount in Swedish Krona: " + totalNumber.ToString("C", swed));
            Console.WriteLine("The amount in Japanese Yen: " + totalNumber.ToString("C", jap));
            Console.WriteLine("The amount in Thai Baht: " + totalNumber.ToString("C", thai));
            Console.ReadKey();
        }
    }
}

