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
                "\n 2 - ");
            int userСhoice = GetInt(nameof(userСhoice));
            if (userСhoice == 1)
            {
                Password();
            }
            else if (userСhoice == 2)
            {

            }
            else if (userСhoice >= 3)
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

}