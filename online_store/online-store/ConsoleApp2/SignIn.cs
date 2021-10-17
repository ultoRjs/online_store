﻿using System;

namespace Online_Shop
{
    public class SignIn
    {
        public void SignInMenu()
        {
            File file = new File();

            file.Read("users");

            User user = new User(
                GetLogin(),
                GetPassword());

            while (!IsCheckSignIn(user.Login, 
                user.Password))
            {
                Console.WriteLine("Incorrect login or password");

                user = new User(
                    GetLogin(),
                    GetPassword());
            }

            Console.Title = $"User: {user.Login}";

            Storage.CurrentUser = user;
        }

        private bool IsCheckSignIn(string login, 
            string password)
        {
            for (int i = 0; i < Storage.Users.Count; i++)
            {
                if (login == Storage.Users[i].Login 
                    && password == Storage.Users[i].Password)
                {
                    return true;
                }
            }

            return false;
        }

        private string GetPassword()
        {
            Console.WriteLine("Enter password");

            string password;

            password = Console.ReadLine();

            Console.Clear();

            return password;
        }

        private string GetLogin()
        {
            Console.WriteLine("Enter login");

            string login;

            login = Console.ReadLine();

            Console.Clear();

            return login;
        }
    }
}