using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Converter
    {
        static int CurrentMoney = 0;
        static int CurrencyСonverted = 0;
        static double Money = 0;
        public static double Convert()
        {
            if (CurrentMoney == 1)
            {
                if(CurrencyСonverted == 2)
                {
                    Money = Money * 0.016f;
                }
                if(CurrencyСonverted == 3)
                {
                    Money = Money * 0.014f;
                }

            }
            else if (CurrentMoney == 2)
            {
                if(CurrencyСonverted == 1)
                {
                    Money = Money * 63.18f;
                }
                if (CurrencyСonverted == 3)
                {
                    Money = Money * 0.91f;
                }

            }
            else if (CurrentMoney == 3)
            {
                if (CurrencyСonverted == 1)
                {
                    Money = Money * 69.67f;
                }
                if (CurrencyСonverted == 2)
                {
                    Money = Money * 1.1f;
                }
            }
            return 0;
        }
    }
}
