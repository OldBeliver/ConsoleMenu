using System;
using System.Threading;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            const string capsLockMenu = "capslock";
            const string numberLockMenu = "numberlock";
            const string beepMenu = "beep";
            const string formatCMenu = "formatc";
            const string clearMenu = "clear";
            const string exitMenu = "exit";
            const string infoMenu = "?";

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
                    case infoMenu:
                        Console.WriteLine($"_______________________________________________________________");
                        Console.WriteLine($"?\t\tсписок команд");
                        Console.WriteLine($"capslock\tвключен или отключен режим CAPS LOCK клавиатуры");
                        Console.WriteLine($"numberlock\tвключен или отключен режим NUM LOCK клавиатуры");
                        Console.WriteLine($"beep\t\tзвуковой сигнал");
                        Console.WriteLine($"formatC\t\tформатирование диска С");
                        Console.WriteLine($"clear\t\tочистить экран");
                        Console.WriteLine($"_______________________________________________________________");
                        break;
                    case capsLockMenu:
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
                    case numberLockMenu:
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
                    case beepMenu:
                        int amount = 3;

                        for (int i = 0; i < amount; i++)
                        {
                            Console.Beep();
                        }

                        Console.WriteLine($"Если Вы слышите 3 звуковых сигнала, значит динамик работает");
                        break;
                    case formatCMenu:
                        Console.WriteLine($"Если Вы слышите звук жужжания жесткого диска, значит процесс форматирования идет успешно");
                        break;
                    case clearMenu:
                        Console.Clear();
                        break;
                    case exitMenu:
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
