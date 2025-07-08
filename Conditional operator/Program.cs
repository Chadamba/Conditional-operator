using System;
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
                "");
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
            
            else if (userСhoice >= 10)
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


}
