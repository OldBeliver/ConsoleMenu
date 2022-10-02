using System;
using System.Threading;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CapsLockMenu = "capslock";
            const string NumberLockMenu = "numberlock";
            const string BeepMenu = "beep";
            const string FormatCMenu = "formatc";
            const string ClearMenu = "clear";
            const string ExitMenu = "exit";
            const string InfoMenu = "?";

            bool doExit = false;

            Console.Title = "Терминал диагностики компьютера";
            Console.WriteLine($"? - список команд");

            while (doExit == false)
            {
                Console.WriteLine($"Введите команду:");
                string userInput = Console.ReadLine().ToLower();
                DateTime timeNow = DateTime.Now;

                switch (userInput)
                {
                    case InfoMenu:
                        Console.WriteLine($"_______________________________________________________________");
                        Console.WriteLine($"{InfoMenu}\t\tсписок команд");
                        Console.WriteLine($"{CapsLockMenu}\tвключен или отключен режим CAPS LOCK клавиатуры");
                        Console.WriteLine($"{NumberLockMenu}\tвключен или отключен режим NUM LOCK клавиатуры");
                        Console.WriteLine($"{BeepMenu}\t\tзвуковой сигнал");
                        Console.WriteLine($"{FormatCMenu}\t\tформатирование диска С");
                        Console.WriteLine($"{ClearMenu}\t\tочистить экран");
                        Console.WriteLine($"_______________________________________________________________");
                        break;
                    case CapsLockMenu:
                        if (Console.CapsLock)
                        {
                            Console.Write($"CapsLock включен");
                        }
                        else
                        {
                            Console.Write($"CapsLock выключен");
                        }

                        Console.WriteLine($"\tвремя проверки {timeNow}");
                        break;
                    case NumberLockMenu:
                        if (Console.NumberLock)
                        {
                            Console.WriteLine($"Num Lock включен");
                        }
                        else
                        {
                            Console.Write($"Num Lock выключен");
                        }

                        Console.WriteLine($"\tвремя проверки {timeNow}");
                        break;
                    case BeepMenu:
                        int amount = 3;

                        for (int i = 0; i < amount; i++)
                        {
                            Console.Beep();
                        }

                        Console.WriteLine($"Если Вы слышите 3 звуковых сигнала, значит динамик работает");
                        break;
                    case FormatCMenu:
                        Console.WriteLine($"Если Вы слышите звук жужжания жесткого диска, значит процесс форматирования идет успешно");
                        break;
                    case ClearMenu:
                        Console.Clear();
                        break;
                    case ExitMenu:
                        doExit = true;
                        break;
                    default:
                        Console.WriteLine($"неизвестная команда {userInput}");
                        break;
                }                
            }
        }
    }
}
