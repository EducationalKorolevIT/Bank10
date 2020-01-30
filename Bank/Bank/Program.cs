using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static public String[] options =
        {
            "Открыть счет",
            "Закрыть счет",
            "Заморозить счет",
            "",
            "Внести",
            "Снять",
            "Выход"
        };

        static List<Account> accounts=new List<Account>();

        static public int selection;
        static public int level;
        static string c = "";
        static bool work = true;
        static void Main(string[] args)
        {
            while (work)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen; //Цвет фона
                Console.ForegroundColor = ConsoleColor.White; //Цвет символов

                Console.Clear(); //Очищаем консоль

                for (int i = 0; i < options.Length; i++) //Выводим все пункты меню
                {
                    if (selection != i) Console.WriteLine("  " + options[i]);
                    else Console.WriteLine("> " + options[i]);
                }

                c = Console.ReadKey(true).Key.ToString(); //Читаем кнопку

                //Логика визу

                //Изменяем выделенный пункт меню
                if (c == "UpArrow") selection--;
                else if (c == "DownArrow") selection++;
                else if (c == "Enter")
                {
                    EnterSelection(selection);
                }


                if (selection < 0) selection = options.Length - 1;
                else if (selection > options.Length - 1) selection = 0;
            }
        }

        static void EnterSelection(int selection)
        {
            Console.Clear();
            switch (selection)
            {
                case 0: Console.WriteLine("Выбрано открытие счета"); openAccount(); Console.ReadKey(); break;
                case 1: Console.WriteLine("Выбрано закрытие счета"); Console.ReadKey(); break;
                case 2: Console.WriteLine("Выбрана заморозка счета"); Console.ReadKey(); break;
                case 4: Console.WriteLine("Выбрано внесение"); Console.ReadKey(); break;
                case 5: Console.WriteLine("Выбрано снятие"); Console.ReadKey(); break;
                case 6: work = false; break;
            }
        }

        static void openAccount()
        {
            Pasport pas;
            Console.WriteLine("Введите ФИО:");
            string names = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            string bday = Console.ReadLine();
            Console.WriteLine("Введите дату пароль:");
            string pass=Console.ReadLine();
            Pasport.birthDate bdate = new Pasport.birthDate();
            bdate.fromString(bday);
            pas = new Pasport(names.Split(' ')[0], names.Split(' ')[1], names.Split(' ')[2], bdate);

            accounts.Add(new Account(pas, pass, "RUB", new Random().Next(0, 100000)));
        }
    }
}
