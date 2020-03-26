using System;
namespace lesson3
{
    public class Programm
    {
        static void Main()
        {
//My Program
            decimal userBalance = 300m;
            string basket = "";
            string erroBalanceMessage = "У вас недостаточно средств";

        start: //Метка "start"

            System.Console.WriteLine($"Ваш баланс - {userBalance}");

            if (userBalance <= 0)
            {
                System.Console.WriteLine(erroBalanceMessage);
                goto End;
            };

            System.Console.WriteLine("" +
            "1 Кола - 10 сомон\n" +
            "2 Сникерс - 7 сомон\n" +
            "3 Пополнить баланс\n" +
            "6 Выход\n" +
            "Ваш выбор (1-6):");

            int choice = int.Parse(Console.ReadLine());

            // goto start; //идти к метке "start"
            switch (choice)
            {
                case 1:
                    {
                        if (userBalance - 10 >= 0)
                        {
                            basket += "Кола,";
                            userBalance -= 10;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Вы хотите продолжить или нет? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    case 2:{//Покупка
                        if (userBalance - 7 >= 0)
                        {
                            basket += "Сникерс,";
                            userBalance -= 7;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Вы хотите продолжить или нет? д/н:");
                        if (Console.ReadLine().ToLower() == "д") goto start;
                        else goto End;
                    }
                    case 3:{//Пополнение
                        System.Console.WriteLine("You can full it with Alif wallet or Alif card\n Enter your mubners:");
                        Console.ReadLine();
                        System.Console.WriteLine("Enter a number:");
                        decimal money = decimal.Parse(Console.ReadLine());
                        userBalance += money;
                        System.Console.Write("Do you want to continue? y/n:");
                        System.Console.WriteLine(userBalance);
                        if (Console.ReadLine().ToLower() == "y") goto start;
                        else goto End;
                    }
                case 6: goto End;
                default: goto start;
                break;
            }

        End:
            System.Console.WriteLine($"Ваши покупки:{basket}\nВаш баланс:{userBalance}");
            Console.ReadKey();
        }
    }
}