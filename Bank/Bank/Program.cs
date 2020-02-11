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
            "Показать счета",
            "Прокрутка дней",
            "Внести",
            "Снять",
            "Перевод денежных средств",
            "Выход"
        };

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
                case 0: 
                    { 
                        Console.WriteLine("Выбрано открытие счета");
                        Score.OpenScore();
                        Console.ReadKey(); 
                    } break;
                case 1:
                    {
                        Console.WriteLine("Выбрано закрытие счета"); 
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Выбрана заморозка счета");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Список счетов");
                        Score.ViewScore();
                        Console.ReadKey();
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Введите номер счета, на котором прокрутить дни:");
                        int num = Score.findScoreByID(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите, сколько дней прокрутить:");
                        int days = Convert.ToInt32(Console.ReadLine());
                        Score.multiplyByDays(num, days);
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Введите номер счета, на который внести:");
                        int num = Score.findScoreByID(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите, сколько денег внести (" + Score.Scores[num].getValuteType() + "):");
                        int money = Convert.ToInt32(Console.ReadLine());
                        Score.Scores[num].addMoney(money);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Введите номер счета, с которого снять:");
                        int num = Score.findScoreByID(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите, сколько денег снять (" + Score.Scores[num].getValuteType() + "):");
                        int money = Convert.ToInt32(Console.ReadLine());
                        Score.Scores[num].subtractMoney(money);
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Введите номер счета, с которого перевести:");
                        int from = Score.findScoreByID(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите номер счета, на который перевести:");
                        int to = Score.findScoreByID(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите, сколько денег перевести (" + Score.Scores[from].getValuteType()+"):");
                        int money = Convert.ToInt32(Console.ReadLine());

                        Score.transfer(from, to, money);
                    }
                    break;
                case 8: 
                    {
                        work = false; 
                    }
                    break;
            }
        }
    }
}
