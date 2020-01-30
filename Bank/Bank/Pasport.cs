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
        }

        long num = 0;
        string name = "";
        string family = "";
        string mName = "";
        birthDate birthday;
        public Pasport(long id,string name,string name2,string name3,birthDate birth)
        {
            this.num = id;
            this.name = name;
            this.family = name2;
            this.mName = name3;
            this.birthday = birth;
        }

        public long getNumber()
        {
            return num;
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
