using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Converter
    {
        public static double Convert(int CurrentMoney,int CurrencyСonverted,double Money)
        {
            if (CurrentMoney == 1)
            {
                if(CurrencyСonverted == 2)
                {
                    Money = Money * 70.05f;
                }
                if(CurrencyСonverted == 3)
                {
                    Money = Money * 1.11f;
                }

            }
            else if (CurrentMoney == 2)
            {
                if(CurrencyСonverted == 1)
                {
                    Money = Money * 0.014f;
                }
                if (CurrencyСonverted == 3)
                {
                    Money = Money * 0.016f;
                }

            }
            else if (CurrentMoney == 3)
            {
                if (CurrencyСonverted == 1)
                {
                    Money = Money * 0.9f;
                }
                if (CurrencyСonverted == 2)
                {
                    Money = Money * 63.38f;
                }
            }
            return Money;
        }
    }
}
