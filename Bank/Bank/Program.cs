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
            "Снять"
        };

        static public int selection;
        static public int level;
        static void Main(string[] args)
        {
            while (true)
            {
                char c = Console.ReadKey(true).KeyChar; //Читаем кнопку


                Console.Clear(); //Очищаем консоль
                Console.WriteLine((int)c);

                //Изменяем выделенный пункт меню
                if (c == 'w' || c == 'W') selection--;
                else if (c == 's' || c == 'S') selection++;
                else if ((int)c == 13) {
                    EnterSelection(selection);
                }
                

                if (selection < 0) selection = options.Length - 1;
                else if (selection > options.Length - 1) selection = 0;


                Console.BackgroundColor = ConsoleColor.DarkGreen; //Цвет фона
                Console.ForegroundColor = ConsoleColor.White; //Цвет символов

                for(int i = 0; i < options.Length; i++) //Выводим все пункты меню
                {
                    if (selection != i) Console.WriteLine("  "+options[i]);
                    else Console.WriteLine("> " + options[i]);
                }
            }
        }

        static void EnterSelection(int selection) {
            switch (selection) { 
            
            }
        }
    }
}
