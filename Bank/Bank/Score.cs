using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    enum Currency
    {
        EUR=1,
        RUB,
        USD
    }
    //валюта

    class Score
    {
        double Money;
        Currency Valute;
        int Id;
        public static int LastId = 0;

        public static List<Score> Scores = new List<Score>();

        public Score()
        {
            Console.Write("Введите тип валюты (1 - EUR, 2 - RUB, 3 - USD):");
            int Currency = Convert.ToInt32(Console.ReadLine());
            if (Currency == 1)
                Valute = Bank.Currency.EUR;
            if (Currency == 2)
                Valute = Bank.Currency.RUB;
            if (Currency == 3)
                Valute = Bank.Currency.USD;
            Console.Write("Введите количество денежных средств:");
            Money = Convert.ToDouble(Console.ReadLine());
            Id = ++LastId;
        }

        public void PrintScore() {
            Console.WriteLine("Номер счёта: " + Id);
            Console.WriteLine("Средств на счету: " + Money);
            if(Valute == Currency.EUR)
                Console.WriteLine("Используемая валюта : EUR");
            if (Valute == Currency.RUB)
                Console.WriteLine("Используемая валюта : RUB");
            if (Valute == Currency.USD)
                Console.WriteLine("Используемая валюта : USD");
        }

        public static void OpenScore()
        {
            Scores.Add(new Score());
            Console.WriteLine("Введите любую клавишу для продолжения...");
        }
        public static void ViewScore()
        {
            foreach (Score sc in Scores) {
                Console.WriteLine();
                sc.PrintScore();
            }
            Console.WriteLine("Введите любую клавишу для продолжения...");
        }

        public void addMoney(double money)
        {
            this.Money += money;
        }

        public void subtractMoney(double money)
        {
            this.Money -= money;
        }

        public static void transfer(int from, int to, double money)
        {
            Score fr = Scores[from];
            Score t = Scores[to];
            if ((int)fr.Valute == (int)t.Valute)
            {
                fr.subtractMoney(money);
                t.addMoney(money);
            }
            else
            {
                fr.subtractMoney(money);
                money = Converter.Convert((int)fr.Valute, (int)t.Valute, money);
                t.addMoney(money);
            }
        }

        public string getValuteType()
        {
            switch ((int)Valute)
            {
                case 1:return "EUR";
                case 2:return "RUB";
                case 3:return "USD";
            }
            return "";
        }
    }
}
