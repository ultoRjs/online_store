﻿using System;

namespace Online_Shop
{
    public class Menu
    {
        public void Show()
        {
            while (true)
            {
                int menu;

                Basket basket = new Basket();

                File file = new File();

                Console.WriteLine("1.Show catalog\n2.Show basket\n3.Product search by name\n4.Show history buy\n5.Exit");

                menu = GetCorrectNumber();

                file.ReadHistoryBuy(Storage.CurrentUser.Login);


                switch (menu)
                {
                    case 1:
                        {
                            basket.MenuAddProductInBasket();

                            break;
                        }
                    case 2:
                        {
                            basket.BuyProductInBasket();

                            break;
                        }
                    case 3:
                        {
                            basket.BuyFoundProduct();

                            break;
                        }
                    case 4:
                        {
                            basket.ShowHistoryBuy();

                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:

                        break;
                }
            }
        }

        private int GetCorrectNumber()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Error");
            }

            return number;
        }
    }
}
