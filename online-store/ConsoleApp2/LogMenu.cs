﻿using System;

namespace Online_Shop
{
    public class LogMenu
    {
        public void ShowMenu()
        {
            int menu;
            SignUp singUp = new SignUp();
            SignIn singIn = new SignIn();
            Console.WriteLine("1.Sign in\n2.Sign up");
            menu = GetCorrectNumber();

            switch (menu)
            {
                case 1:
                    {
                        singIn.SignInMenu();
                        break;
                    }

                case 2:
                    {
                        singUp.SignUpMenu();
                        break;
                    }
                default:
                    break;
            }

        }

        private int GetCorrectNumber()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error");
            }

            Console.Clear();

            return number;
        }
    }
}
