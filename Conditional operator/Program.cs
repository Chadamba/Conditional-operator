using System;

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
                "\n 4 - ");
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
                ;
            }
            else if (userСhoice >= 5)
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
}