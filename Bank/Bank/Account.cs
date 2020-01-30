using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        Pasport passData;
        string password = "";
        bool enabled = true;
        bool loggedIn = false;
        string val;
        float money;
        long number;
        public Account(Pasport data, string pass, string value, long n)
        {
            this.passData = data;
            this.password = pass;
            this.val = value;
            this.number = n;
        }

        public Boolean login(Pasport data,string pass)
        {
            loggedIn=this.passData.Equals(data) && this.password==pass;
            return loggedIn;
        }
        public void addMoney(float money)
        {
            this.money += money;
        }

        public void subMoney(float money)
        {
            if (loggedIn) this.money -= money;
        }

        public float getCurrMoney()
        {
            return money;
        }
    }
}
