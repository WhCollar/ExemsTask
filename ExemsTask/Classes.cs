using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemsTask
{
    class Person //Task1 Билет 1
    {
        public string? Name { get; init; }

        public void Greetings() => Console.WriteLine($"Привет {Name}!");
    }


    class Calculatetor //Task2 Билет 2
    {
        public double X { get; init; }
        public double Y { get; init; }

        private double Resualt = 0;

        public void Division()
        {
            try { 
                Resualt = X / Y; 
            }
            catch(ArithmeticException e) { 
                Console.WriteLine($"Арифметическая ошибка: {e}"); 
            }
        }

        public void ShowResual() => Console.WriteLine($"Ответ: {Resualt}");

    }

    class BankAccount //Task3 Билет 3
    {
        public enum AccountTypes { Current, Saving }

        public AccountTypes accountType;

        public BankAccount(AccountTypes typeOfAccount) { accountType = typeOfAccount; }

        public void AccountTypesShow() => Console.WriteLine($"Тип акаунта: {accountType}");

    } 

    struct BankAccountData //Task4 Билет 4
    {
        public enum AccountTypes { Current, Saving }

        public AccountTypes accountType;

        public long AccountNumber;

        public decimal AccountBalance;

        public BankAccountData(AccountTypes typeOfAccount, long accountNumber, decimal accountBalance = 0) 
        { 
            accountType = typeOfAccount; 
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }

        public void ShowData() => Console.WriteLine($"Тип счёта: {accountType}, Номер счёта: {AccountNumber}, Баланс счёта: {AccountBalance}");

    }

    class DayNumConvert //Task5 Билет 5-6
    {
        private static Dictionary<int, string> Month = new()
        {
            { 1, "Январь" },
            { 2, "Февраль" },
            { 3, "Март" },
            { 4, "Апрель" },
            { 5, "Май" },
            { 6, "Июнь" },
            { 7, "Июль" },
            { 8, "Август" },
            { 9, "Сентябрь" },
            { 10, "Октябрь" },
            { 11, "Ноябрь" },   
            { 12, "Декабрь" }
        };

        private int dayNum;

        private DateTime dateTime = Convert.ToDateTime("01.01.2022");

        public DayNumConvert(int DayNum)
        {
            dayNum = DayNum;

            if (1 > DayNum || DayNum > 365)
            {
                throw new ArgumentException($"Введённое число {dayNum} не входит в диапазон [1;365].");
            }
            else
            {
                dateTime = dateTime.AddDays(dayNum - 1);
            }
        }
        public void ShowMonthAndDay() => Console.WriteLine($"{Month[dateTime.Month]} {dateTime.Day}");

    }

    class AvarageTemperatureOfYear //Task6 Билет 7
    {
        private static string[] Month = new string[12] 
        {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        };

        private List<double> temperatureList = new List<double> {};

        private double avarageTemperature;

        public void TemperatureListSet()
        {
            foreach (string month in Month)
            {
                Console.WriteLine($"Введите температуру за {month}:");
                temperatureList.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        private void CalculateAvarageTemperature()
        {
            avarageTemperature = temperatureList.Sum() / temperatureList.Count();
        }

        public void AvarageTemperatureShow()
        {
            CalculateAvarageTemperature();
            Console.WriteLine($"Средняя температура в течении года составила: {avarageTemperature}");
        }

    }

    class BankAccountP //Task7 Билет 8
    {
        public enum AccountTypes { Current, Saving }

        private AccountTypes accountType { get; set; }

        private long AccountNumber { get; set; }

        private decimal AccountBalance { get; set; }

        public BankAccountP(AccountTypes typeOfAccount, long accountNumber, decimal accountBalance = 0)
        {
            accountType = typeOfAccount;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }

        public void ShowBankAccountP() => Console.WriteLine($"Тип счёта: {accountType}, Номер счёта: {AccountNumber}, Баланс счёта: {AccountBalance}");

    }

    class ReverseString //Task8 Билет 9
    {
        private string text { get; set; }

        public ReverseString(string Text) => text = Text;

        public string Reverse()
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public void ShowReversedText() => Console.WriteLine(Reverse());

    }

    class FileTitleUpper //Task9 Билет 10
    {
        public string AbsolutePath { get; set; }

        private string text;

        public void CopyWithUpTitle()
        {
            if (File.Exists(AbsolutePath))
            {
                using (StreamReader reader = new StreamReader(AbsolutePath))
                {
                    text = reader.ReadToEnd();
                }
                text = text.ToUpper();
                Console.WriteLine(text);
                using (StreamWriter writer = new StreamWriter(AbsolutePath, false))
                {
                    writer.WriteLineAsync(text);
                }
            }
            else
            {
                throw new Exception($"Файл с абсолютным именем {AbsolutePath} не существует.");
            }
        }
        
    }




}
