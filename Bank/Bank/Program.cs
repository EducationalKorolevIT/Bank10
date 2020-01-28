using System;

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

        static public int selection;
        static public int level;
        static char c='w';
        static bool work = true;
        static void Main(string[] args)
        {
            while (work)
            {
                Console.Clear(); //Очищаем консоль

                for (int i = 0; i < options.Length; i++) //Выводим все пункты меню
                {
                    if (selection != i) Console.WriteLine("  " + options[i]);
                    else Console.WriteLine("> " + options[i]);
                }

                c = Console.ReadKey(true).KeyChar; //Читаем кнопку

                //Логика визу

                //Изменяем выделенный пункт меню
                if (c == 'w' || c == 'W') selection--;
                else if (c == 's' || c == 'S') selection++;
                else if ((int)c == 13)
                {
                    EnterSelection(selection);
                }


                if (selection < 0) selection = options.Length - 1;
                else if (selection > options.Length - 1) selection = 0;


                Console.BackgroundColor = ConsoleColor.DarkGreen; //Цвет фона
                Console.ForegroundColor = ConsoleColor.White; //Цвет символов
            }
        }

        static void EnterSelection(int selection) {
            switch (selection) {
                case 0:Console.WriteLine("Выбрано открытие счета");Console.ReadKey();break;
                case 1:Console.WriteLine("Выбрано закрытие счета");Console.ReadKey();break;
                case 2:Console.WriteLine("Выбрана заморозка счета");Console.ReadKey();break;
                case 4:Console.WriteLine("Выбрано внесение");Console.ReadKey();break;
                case 5:Console.WriteLine("Выбрано снятие");Console.ReadKey();break;
                case 6:work = false;break;
            }
            Console.Clear();
        }
    }
}
