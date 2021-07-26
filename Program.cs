using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipinLoginAndPassword
{
    class Program
    {
        //Скипин Михаил Реализация программы логин и пароль
        
        static void LOGIN()

        {
            string login = "root";
            string password = "GeekBrains";
            int i = 1;
            do
            {
                Console.WriteLine("Введите логин");
                var log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var pass = Console.ReadLine();
                
                if (log != login && pass != password)
                {
                    Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз. Внимание! У вас есть не более трех попыток. ");
                    i++; 
                }
                else
                {
                  Console.WriteLine("Вы проходите на следующий уровень");
                    break;
                }
            }
            while (i < 4);
                   


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Вам необходимо авторизироваться");
            LOGIN();

        }
    }
}
