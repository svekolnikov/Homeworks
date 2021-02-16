using System;

namespace Lesson2
{
    enum Months
    {
        January = 1, February, March, April, May, June, Jule, August, September, October, November, December
    }

    [Flags]
    enum WeekDays 
    {
        Monday      = 0b00000001,
        Tuesday     = 0b00000010,
        Wednesday   = 0b00000100,
        Thursday    = 0b00001000,
        Friday      = 0b00010000,
        Saturday    = 0b00100000,
        Sunday      = 0b01000000
    }

    class Program
    {      
        static void Main()
        {
            //Task 1
            Console.Write("Please enter minimal temperature:");
            string minTempS = Console.ReadLine();
            int minTemp = Convert.ToInt32(minTempS);
            Console.Write("Please enter minimal temperature:");
            string maxTempS = Console.ReadLine();
            int maxTemp = Convert.ToInt32(maxTempS);
            double avgTemp = (maxTemp + minTemp) / 2;
            Console.WriteLine($"Averrage temperature is: {avgTemp}");

            //Task2
            Console.Write("Please enter current month number:");
            int monthNum = Convert.ToInt32(Console.ReadLine());
            Months month = (Months)monthNum;
            Console.WriteLine($"Current month is: {month}");

            //Task3
            Console.Write("Please enter number:");
            int numEvenOrOdd = Convert.ToInt32(Console.ReadLine());
            string numEvenOrOddS = numEvenOrOdd % 2 == 0 ? "even" : "odd";
            Console.WriteLine($"The number {numEvenOrOdd} is {numEvenOrOddS}");

            //Task4
            string companyName = "OOO Чек";
            double checkNumber = 2047463;
            string casherSurname = "Ivanov";

            string prod1 = "Хлеб";
            double prod1Price = 46.50;
            float prod1Qty = 2.00f;
            double prod1Total = prod1Price * prod1Qty;

            string prod2 = "Молоко";
            double prod2Price = 75.00;
            float prod2Qty = 3.00f;
            double prod2Total = prod2Price * prod2Qty;

            string prod3 = "Мясо";
            double prod3Price = 350.00;
            float prod3Qty = 1.85f;
            double prod3Total = prod3Price * prod3Qty;

            double tatalPrice = prod1Total + prod2Total + prod3Total;
            float ndsPerc = 18.00f;
            double ndsAmount = tatalPrice * (ndsPerc / 100);

            double tatalPriceWithNds = tatalPrice + ndsAmount;

            DateTime purchaseTime = new DateTime(2021, 2, 16, 13, 15, 57);

            Console.WriteLine($"***************** {companyName} *****************");
            Console.WriteLine($"           Кассир {casherSurname} ***************");
            Console.WriteLine($"             Чек №{checkNumber}");
            Console.WriteLine($"Товар........Цена.....Кол-во.....Стоимость");
            Console.WriteLine($"{prod1}........{prod1Price:F2}.....{prod1Qty:F2}.....{prod1Total:F2} руб.");
            Console.WriteLine($"{prod2}........{prod2Price:F2}.....{prod2Qty:F2}.....{prod2Total:F2} руб.");
            Console.WriteLine($"{prod3}........{prod3Price:F2}.....{prod3Qty:F2}.....{prod3Total:F2} руб.");
            Console.WriteLine($"НДС {ndsPerc:F2}%.........................{ndsAmount:F2} руб.");
            Console.WriteLine($"ИТОГО {tatalPriceWithNds:F2} руб............. Дата:{purchaseTime:MM/dd/yy H:mm:ss}");

            //Task5
            Console.Write("Please enter current month number:");
            int mNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the temperature:");
            int temp = Convert.ToInt32(Console.ReadLine());
            if ((mNum < 3 || mNum == 12) && temp > 0)
            {
                Console.WriteLine("Дождливая зима");
            }

            //Task6
            WeekDays office1 = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday;
            WeekDays office2 = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday | WeekDays.Sunday;
            Console.WriteLine($"Office1 works on: {office1}");
            Console.WriteLine($"Office2 works on: {office2}");

            Console.ReadKey();
        }
    }
}
