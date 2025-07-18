﻿using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class MainClass
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("МЕНЮ:" +
                "\n" +
                "\n Выберите пункт из списка." +
                "\n" +
                "\n 1 - Пароль" +
                "\n 2 - Возрастное ограничение" +
                "\n 3 - Максимум из двух чисел" +
                "\n 4 - Чётное число" +
                "\n 5 - Делимость" +
                "\n 6 - Знак числа" +
                "\n 7 - Калькулятор" +
                "\n 8 - Симетричное число" +
                "\n 9 - Возрастающее число" +
                "\n 10 - Мы играем в футбол" +
                "\n 11 - Да или нет" +
                "\n 12 - Сумма" +
                "\n 13 - Сумма 2" +
                "\n 14 - Обратное число" +
                "\n 15 - Артур и поход в магазин" +
                "\n 16 - На электросамокате с ветерком" +
                "\n 17 - Стоимость перелёта" +
                "\n 18 - Система наблюдения");
            int userСhoice = GetInt(nameof(userСhoice));
            if (userСhoice == 1)
            {
                Password();
            }
            else if (userСhoice == 2)
            {
                AgeRestrictions();
            }
            else if (userСhoice == 3)
            {
                MaximumOfTwoNumbers();
            }
            else if (userСhoice == 4)
            {
                AnEvenNumber();
            }
            else if (userСhoice == 5)
            {
                Divisibility();
            }
            else if (userСhoice == 6)
            {
                NumberSign();
            }
            else if (userСhoice == 6)
            {
                PointAffiliation();
            }
            else if (userСhoice == 7)
            {
                calculate();
            }

            else if (userСhoice == 8)
            {
                ASymmetricNumber();
            }
            else if (userСhoice == 9)
            {
                IncreasingSequence();
            }
            else if (userСhoice == 10)
            {
                WePlayFootball();
            }

            else if (userСhoice == 11)
            {
                YESorNO();
            }
            else if (userСhoice == 12)
            {
                Sum();
            }
            else if (userСhoice == 13)
            {
                Sum2();
            }
            else if (userСhoice == 14)
            {
                ReverseNumber();
            }
            else if (userСhoice == 15)
            {
                TripToStore();
            }
            else if (userСhoice == 16)
            {
                OnAnElectricScooterWithABreeze();
            }
            else if (userСhoice == 17)
            {
                FlightCost();
            }
            else if (userСhoice == 18)
            {
                SurveillanceSystem();
            }

            else if (userСhoice >= 19)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Несуществующий пункт");
            }
            Console.ResetColor();
        }

    }

    static int GetInt(string name)
    {
        bool check;
        int number;
        do
        {
            check = int.TryParse(Console.ReadLine(), out number);
            if (!check) Console.WriteLine("Вы ввели неправильное значение." +
                "\n Введите правильное значение =" + name + ".");
        }
        while (!check);
        return number;
    }

    /*Пароль
При регистрации на сайтах обычно просят дважды ввести пароль — это снижает вероятность ошибки при вводе.
Напиши программу, которая сравнивает введённый пароль и его подтверждение.
Если строки совпадают, программа должна вывести сообщение: Пароль принят, иначе: Пароль не принят
Формат входных данных:
Две строки — пароль и его подтверждение.
Формат выходных данных:
Одна строка — результат проверки  в соответствии с условием задачи.*/
    static void Password()
    {
        Console.WriteLine("Регистрация пароля:" +
            "\n" +
            "Введите новый пароль:");
        string newpassword = Console.ReadLine();
        Console.WriteLine("Подвердтите пароль:");
        string reenterPassword = Console.ReadLine();
        if (newpassword == reenterPassword)
        {
            Console.WriteLine("Пароль подвержден.");
        }
        else
        {
            Console.WriteLine("Пароли не совпадают");
        }
    }

    /*Доступ к IRON PROGRAMMER
Напиши программу, которая определяет, разрешён ли пользователю доступ к курсам школы IRON PROGRAMMER.
Если возраст пользователя не менее 12 лет, программа должна вывести сообщение: Доступ разрешен, иначе: Доступ запрещен */
    static void AgeRestrictions()
    {
        Console.WriteLine("Введите свой возраст");
        int age = GetInt(nameof(age));
        if (age >= 12)
        {
            Console.WriteLine("Доступ разрешен");
        }
        else
        {
            Console.WriteLine("Доступ запрещен");
        }
    }

    /*Максимум из двух чисел
Напиши программу, которая находит максимальное из двух целых чисел.Если числа равны, выведи любое из них.
Формат входных данных:
Два целых числа, каждое из которых не превышает 10000.
Формат выходных данных:
Одно число — максимальное из двух исходных чисел.*/
    static void MaximumOfTwoNumbers()
    {
        Console.WriteLine("Введите первое число которое не превышает 10 000");
        int firstNumber = GetInt(nameof(firstNumber));
        Console.WriteLine("Введите второе число которое не превышает 10 000");
        int secondNumber = GetInt(nameof(secondNumber));
        if (firstNumber >= secondNumber)
        {
            Console.WriteLine($"{firstNumber}");
        }
        else
        {
            Console.WriteLine($"{secondNumber}");
        }
    }
    /*Чётное число
Напиши программу, которая определяет, является ли заданное целое число чётным.
Если число четное, программа должна вывести сообщение: YES, иначе: NO
Формат входных данных:
Одно целое число, по модулю не превышающее 10^7.
Формат выходных данных:
Одна строка — результат проверки  в соответствии с условием задачи.*/
    static void AnEvenNumber()
    {
        Console.WriteLine("Введите значение: ");
        int number = GetInt(nameof(number));
        if (number % 2 == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    /*Делимость
Напиши программу, которая проверяет, делится ли одно целое число a на другое целое число b нацело.
Если a делится на b нацело, программа должна вывести сообщение: YES, иначе: NO*/
    static void Divisibility()
    {
        Console.WriteLine("Введиет первое число: ");
        int firstNumber = GetInt(nameof(firstNumber));
        Console.WriteLine("Введиет второе число не равное нулю: ");
        int secondNumber = GetInt(nameof(secondNumber));
        if (firstNumber % secondNumber == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
    static void NumberSign()
    {
        Console.WriteLine("Введите значение");
        int number = GetInt(nameof(number));
        if (number > 0)
        {
            Console.WriteLine(1);
        }
        else if (number == 0)
        {
            Console.WriteLine(0);
        }
        else if (number < -1)
        {
            Console.WriteLine(-1);
        }
    }
    /*Определи, принадлежит ли точка X одному из выделенных отрезков AB или CD(включая границы). Если принадлежит, программа должна вывести сообщение: YES, иначе: NO.
Формат входных данных:
Одно целое число x, по модулю не превышающее 10000.
Формат выходных данных:
Одна строка — результат проверки  в соответствии с условием задачи.*/
    static void PointAffiliation()
    {
        int n = GetInt(nameof(n));
        if (-3 <= n && n <= 1)
        {
            Console.WriteLine("YES");
        }
        else
        {
            if (5 <= n && n <= 9)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    static void calculate()
    {
        Console.Write("Введите первое число: ");
        double x = GetDouble(nameof(x));
        Console.Write("Введите второе число: ");
        double y = GetDouble(nameof(y));
        Console.Write("Введите оператор(+,-,*,/): ");
        string operation = Convert.ToString(Console.ReadLine());



        if (operation == "+")
        {
            Console.WriteLine(x + y);
        }
        else
        {
            if (operation == "-")
            {
                Console.WriteLine(x - y);
            }
            else
            {
                if (operation == "*")
                {
                    Console.WriteLine(x * y);
                }
                else
                {
                    if (operation == "/" && x != 0 && y != 0)
                    {
                        Console.WriteLine(x / y);
                    }
                    else
                    {
                        if (x == 0 || y == 0 && operation == "/")
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                        }
                        else
                        {
                            if (operation != "+" || operation != "-" || operation != "/" || operation != "*")
                            {
                                Console.WriteLine("Неверная операция");
                            }
                        }
                    }

                }

            }
        }
    }
    static double GetDouble(string name)
    {
        bool check;
        double number;
        do
        {
            check = double.TryParse(Console.ReadLine(), out number);
            if (!check) Console.WriteLine("Вы ввели неправильное значение." +
                "\n Введите правильное значение =" + name + ".");
        }
        while (!check);
        return number;

    }

    static void ASymmetricNumber()
    {
        Console.WriteLine("Введите число в диапазоне от 1000 до 9999 включительно.");
        int fourDigitNumber = GetInt(nameof(fourDigitNumber));
        int firstNumber = fourDigitNumber % 10;
        int secondNumber = (fourDigitNumber / 10) % 10;
        int thirdNumber = (fourDigitNumber / 100) % 10;
        int fourthNumber = fourDigitNumber / 1000;

        if (firstNumber == fourthNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    static void IncreasingSequence()
    {
        Console.WriteLine("Введите число в диапазоне от 100 до 999 включительно.");
        int fourDigitNumber = GetInt(nameof(fourDigitNumber));
        int firstNumber = fourDigitNumber % 10;
        int secondNumber = (fourDigitNumber / 10) % 10;
        int thirdNumber = (fourDigitNumber / 100) % 10;
        if (firstNumber > secondNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
    /*Футбольная команда набирает мальчиков от 12 до 18 лет включительно.Напиши программу, 
     * которая запрашивает возраст и пол претендента, используя обозначение пола буквы m (от male – мужчина) и f(от female – женщина) и определяет,
     * подходит ли претендент для вступления в команду или нет.
Если претендент подходит, программа должна вывести YES, в противном случае — NO*/

    static void WePlayFootball()
    {
        Console.WriteLine("Введите возраст ");
        int age = GetInt(nameof(age));
        Console.WriteLine("Введите пол m (от male – мужчина) и f(от female – женщина)");
        string gender = Console.ReadLine();
        if (age >= 12 && age <= 18 && gender == "m")
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    /*YES or NO — вот в чём вопрос
 Напиши программу, которая принимает на вход число и в зависимости от условий выводит текст YES или NO.
 Условия:
 если число нечётное, то вывести YES;
 если число чётное в диапазоне от 2 до 5 (включительно), то вывести NO;
 если число чётное в диапазоне от 6 до 20 (включительно), то вывести YES;
 если число чётное и больше 20, то вывести NO.*/

    static void YESorNO()
    {
        Console.Write("Введите число: ");
        int x = GetInt(nameof(x));
        if (x % 2 != 0 || x % 2 == 0 && x >= 6 && x <= 20)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    static void Sum()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;


        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            sum = sum + number;
        }

        Console.WriteLine(sum);
    }
    static void Sum2()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0 && number % 3 != 0)
            {
                sum = sum + number;
            }

        }
        Console.WriteLine(sum);
    }
    static void ReverseNumber()
    {
        Console.WriteLine("Введите число: ");
        string number = Console.ReadLine();
        double numberConversFromString = Convert.ToDouble(number);
        if (numberConversFromString == 0)
        {
            Console.WriteLine("Обратного числа не существует");
        }
        else
        {
            double reverseNumber = 1 / numberConversFromString;
            Console.WriteLine($"{reverseNumber}");
        }
    }
    static void TripToStore()
    {
        Console.WriteLine("Поход в магазин. " +
            "\nВ данном простом примере вам надо вести 3 разных числа, и рассчитается минимальный путь" +
            "\nВведите расстояние от дома к первому магазину");
        int d1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите растояние от дома к второму магазину");
        int d2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите растояние от первого магазина к второму магазину");
        int d3 = Convert.ToInt32(Console.ReadLine());

        int sum1 = d1 + d3 + d2;
        int sum2 = d1 + d1 + d2 + d2;
        int sum3 = d1 + d3 + d3 + d1;
        int sum4 = d2 + d3 + d3 + d2;

        int result = Math.Min(sum1, sum2);
        result = Math.Min(result, sum3);
        result = Math.Min(result, sum4);
        Console.WriteLine($"Самый короткий путь {result}");
    }

    static void OnAnElectricScooterWithABreeze()
    {
        Console.Write("Стоимость тарифа на день (в рублях) = ");
        int costOfTariffPerDay = GetInt(nameof(costOfTariffPerDay));
        Console.Write("Количество бесплатных минут = ");
        int freeMinutes = GetInt(nameof(freeMinutes));
        Console.Write("Фактическая длительность поездки (в минутах) = ");
        int actualDurationInMinutes = GetInt(nameof(costOfTariffPerDay));
        Console.Write("Стоимость одной дополнительной минуты после превышения лимита = ");
        int costOfOneAdditionalMinute = GetInt(nameof(costOfTariffPerDay));

        int exceedLimit = actualDurationInMinutes - freeMinutes; //Находим, сколько минут Андрей израсходовал сверх тарифа
        if (exceedLimit > 0)
        {
            int fullCostOfAdditionalMinutes = exceedLimit * costOfOneAdditionalMinute; // Умножим полученную разницу на цену дополнительных минут
            int fullCostOfTariff = costOfTariffPerDay + fullCostOfAdditionalMinutes; // Сложим стоимость дополнительных минут со стоимостью тарифа
            Console.WriteLine($"К опалте тарифа аренды самоката = {fullCostOfTariff}");
        }
        else
        {
            Console.WriteLine($"К опалте тарифа аренды самоката = {costOfTariffPerDay}");
        }
    }

    static void FlightCost()
    {
        Console.Write("Цена билета = ");
        int ticketPrice = GetInt(nameof(ticketPrice));

        Console.Write("Стоимость места у окна  = ");
        int costOfWindowSeat = 0;
        string entry = Console.ReadLine();
        if (!string.IsNullOrEmpty(entry))
        {

            int.TryParse(entry, out costOfWindowSeat);
        }

        Console.Write("Стоимость бортового питания  = ");
        int costOfOnBoardMeals = 0;
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {

            int.TryParse(input, out costOfOnBoardMeals);
        }

        Console.Write("Масса ручной клади Михаила в килограммах = ");
        int weightOfHandLuggage = GetInt(nameof(weightOfHandLuggage));

        int fullTicketPrice = ticketPrice + costOfWindowSeat + costOfOnBoardMeals;

        if (weightOfHandLuggage > 3)
        {
            weightOfHandLuggage = 200 * (weightOfHandLuggage - 3);
        }
        else if (weightOfHandLuggage <= 3)
        {
            weightOfHandLuggage = 0;
        }
        int totalTicketPrice = fullTicketPrice + weightOfHandLuggage;
        Console.WriteLine($"Полёт обойдётся в {totalTicketPrice} рублей ");
    }

    static void SurveillanceSystem()
    {
        int num = Convert.ToInt32(Console.ReadLine());

        int d = num % 10;
        int h = num % 100;

        if (d == 1 && h != 11)
        {
            Console.WriteLine(num + " Гимназист");
        }
        else if ((2 <= d && d <= 4) && !(12 <= h && h <= 14))
        {
            Console.WriteLine(num + " Гимназиста");
        }
        else
        {
            Console.WriteLine(num + " Гимназистов");
        }
    }
}
