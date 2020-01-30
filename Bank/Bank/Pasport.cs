using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Pasport
    {
        public struct birthDate
        {
            int day;
            int month;
            int year;
            public void fromString(string dat)
            {
                string[] data = dat.Split('.');
                day = Convert.ToInt32(data[0]);
                month = Convert.ToInt32(data[1]);
                year = Convert.ToInt32(data[2]);
            }
        }

        string name = "";
        string family = "";
        string mName = "";
        birthDate birthday;
        public Pasport(string name,string name2,string name3,birthDate birth)
        {
            this.name = name;
            this.family = name2;
            this.mName = name3;
            this.birthday = birth;
        }

        public string getFullName()
        {
            return name + " " + family + " " + mName;
        }
        public birthDate getBirthday()
        {
            return birthday;
        }
    }
}
