//***********************************************************************
//* Практичсекая работа № 6                                             *
//* Выполнила: Трухина Е.Д., группа 2ИСП                                *
//* Задание: составить программу разветвляющейся усложненной структуры  *
//***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Title = "Практическая работа 6";
            Console.ForegroundColor = ConsoleColor.White;

            double N;

            Console.WriteLine("Здравствуй!");
            Console.Write("Введите N = ");

            try
            {
                N = Convert.ToDouble(Console.ReadLine()); // Конвертируем вводимое число в double

                //Берем модуль числа, чтобы проверять и отрицательные значения
                double absN = Math.Abs(N);

                // Проверяем, является ли число четырехзначным (по модулю)
                if (absN >= 1000 && absN <= 9999)
                {
                    //Проверяем на четность. 
                    if (absN % 2 == 0)
                    {
                        Console.WriteLine("Число " + N + " является четным четырехзначным числом.");
                    }
                    else
                    {
                        Console.WriteLine("Число " + N + " является четырехзначным, но нечетным.");
                    }
                }
                else
                {
                    Console.WriteLine("Число " + N + " не является четырехзначным.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Вы ввели не число! Пожалуйста, введите цифры."); //Если пользователь вводит символы вместо цифр
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком большое или слишком маленькое."); //Если введенное число слишком большое или маленькое для типа double
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message); //Любая другая ошибка
            }

            Console.ReadKey();
        }
    }
}
